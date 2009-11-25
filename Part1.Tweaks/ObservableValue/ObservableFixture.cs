using System;
using NUnit.Framework;

namespace Part1.Tweaks.ObservableValue
{
	[TestFixture]
	public class ObservableFixture
	{

		[Test]
		public void Should_throw()
		{
			var model = new ViewModel();

			model.BooleanProperty.PropertyChanged += (sender, args) => Console.WriteLine(args.PropertyName);
			model.BooleanProperty.Value = true;

			model.StringProperty.PropertyChanged += (sender, args) => Console.WriteLine(args.PropertyName);
			model.StringProperty.Value = "new value";
		}
	}
}