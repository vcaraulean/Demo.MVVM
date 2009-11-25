using Caliburn.Testability;
using NUnit.Framework;

namespace Part3.CaliburnTestability
{
	[TestFixture]
	public class BindingFixture
	{
		ValidationResult<PersonViewModel> validationResult;

		[SetUp]
		public void SetUp()
		{
			validationResult = Validator.For<PersonView, PersonViewModel>().Validate();
		}

		[Test]
		public void Should_detect_binding_errors()
		{
			validationResult.AssertNoErrors();
		}

		[Test]
		public void Property_Age_from_VM_is_bound()
		{
			validationResult.AssertWasBound(m => m.Age);
		}

		[Test]
		public void Property_Name_from_VM_is_bound()
		{
			validationResult.AssertWasBound(m => m.Name);
		}
	}
}