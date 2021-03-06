using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Part4.MixItUp.ViewModels
{
	public class Naked_CreateEmployeeViewModel : INotifyPropertyChanged
	{
		private string firstName;
		private string lastName;

		public Naked_CreateEmployeeViewModel()
		{
			SaveCommand = new DelegateCommand(Save, () => CanSave);
		}

		public string FirstName
		{
			get { return firstName; }
			set
			{
				firstName = value;
				NotifyOfPropertyChange("FirstName");
			}
		}

		public string LastName
		{
			get { return lastName; }
			set
			{
				lastName = value;
				NotifyOfPropertyChange("LastName");
			}
		}

		public ICommand SaveCommand { get; private set; }

		public bool CanSave
		{
			get { return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName); }
		}

		public void Save()
		{
			MessageBox.Show(string.Format("Saved '{0} {1}'.", FirstName, LastName));
		}

		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		public void NotifyOfPropertyChange(string propertyName)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}