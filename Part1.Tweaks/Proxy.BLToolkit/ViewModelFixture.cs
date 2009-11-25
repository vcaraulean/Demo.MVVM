using BLToolkit.Reflection;
using NUnit.Framework;

namespace Part1.Tweaks.Proxy.BLToolkit
{
	[TestFixture]
	public class ViewModelFixture
	{
		[Test]
		public void INotifyPropertyChanged_is_implemented()
		{
			var viewModel = TypeAccessor.CreateInstance<ViewModel>();

			string changedProperty = null;
			viewModel.PropertyChanged += (sender, args) => changedProperty = args.PropertyName;

			viewModel.SimpleProperty = "new value";
			Assert.That(changedProperty, Is.EqualTo("SimpleProperty"));
		}

		[Test]
		public void EditableObject_Demo()
		{
			var viewModel = TypeAccessor.CreateInstance<ViewModel>();
			Assert.That(viewModel.IsDirty == false);

			viewModel.SimpleProperty = "new value";
			Assert.That(viewModel.IsDirty);

			viewModel.AcceptChanges();
			Assert.That(viewModel.IsDirty == false);

			viewModel.SimpleProperty = "other value";
			viewModel.RejectChanges();
			Assert.That(viewModel.SimpleProperty == "new value");
		}
	}
}