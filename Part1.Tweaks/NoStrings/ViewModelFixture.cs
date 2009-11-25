using System;
using NUnit.Framework;

namespace Part1.Tweaks.NoStrings
{
	[TestFixture]
	public class ViewModelFixture
	{
		[Test]
		public void Should_notify_when_property_changed()
		{
			var vm = new ViewModel();
			vm.PropertyChanged += (sender, args) => Console.WriteLine("Property changed: " + args.PropertyName);
			vm.FirstProperty = "value";
		}

		[Test]
		public void Should_notify_when_property_changed_with_lambda_expression()
		{
			var vm = new ViewModel();
			vm.PropertyChanged += (sender, args) => Console.WriteLine("Property changed: " + args.PropertyName);
			vm.SecondProperty= "value";
		}

		[Test]
		public void Should_throw_if_property_not_found()
		{
			var vm = new ViewModel();
			Assert.Throws<ArgumentException>(() => vm.ThirdProperty = "");
		}
	}
}