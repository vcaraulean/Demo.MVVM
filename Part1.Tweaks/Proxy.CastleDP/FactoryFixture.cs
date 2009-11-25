using System.ComponentModel;
using NUnit.Framework;
using Part1.Tweaks.Proxy.CastleDP.Impl;

namespace Part1.Tweaks.Proxy.CastleDP
{
	[TestFixture]
	public class FactoryFixture
	{
		[Test]
		public void Should_proxy_the_type()
		{
			var viewModel = DataBindingFactory.Create<ViewModel>();
			
			string argPropertyName = null;
			((INotifyPropertyChanged)viewModel).PropertyChanged += (sender, args) => argPropertyName = args.PropertyName;
			
			viewModel.MyProperty = "new value";
			
			Assert.That(argPropertyName, Is.EqualTo("MyProperty"));
		}
	}
}