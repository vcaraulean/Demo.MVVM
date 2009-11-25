using Caliburn.Testability;
using NUnit.Framework;
using Part4.MixItUp.ViewModels;
using Part4.MixItUp.Views;

namespace Part4.MixItUp
{
	[TestFixture]
	public class DataBindingFixture
	{
		[Test]
		public void Verify()
		{
			Validator.For<CreateEmployeeView, CreateEmployeeViewModel>().Validate().AssertNoErrors();
		}
	}
}