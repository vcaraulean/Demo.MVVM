using System.Windows;
using BLToolkit.EditableObjects;

namespace Part4.MixItUp.ViewModels
{
	public abstract class CreateEmployeeViewModel : EditableObject<CreateEmployeeViewModel>
	{
		public abstract string FirstName { get; set; }
		public abstract string LastName { get; set; }

		public bool CanSaveAnEmployee()
		{
			return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
		}

		public void SaveEmployee()
		{
			MessageBox.Show(string.Format("Saved '{0} {1}'.", FirstName, LastName));
		}
	}
}