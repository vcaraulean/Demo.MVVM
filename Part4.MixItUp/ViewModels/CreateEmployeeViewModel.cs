using System.Windows;
using BLToolkit.EditableObjects;
using Caliburn.PresentationFramework.Filters;

namespace Part4.MixItUp.ViewModels
{
	public abstract class CreateEmployeeViewModel : EditableObject<CreateEmployeeViewModel>
	{
		public abstract string FirstName { get; set; }
		public abstract string LastName { get; set; }

		[Dependencies("FirstName", "LastName")]
		public void SaveEmployee()
		{
			MessageBox.Show(string.Format("Saved '{0} {1}'.", FirstName, LastName));
		}

		public bool CanSaveEmployee()
		{
			return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
		}
	}
}