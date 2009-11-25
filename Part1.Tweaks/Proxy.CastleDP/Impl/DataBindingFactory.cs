using System;
using System.ComponentModel;
using Castle.DynamicProxy;

namespace Part1.Tweaks.Proxy.CastleDP.Impl
{
	public class DataBindingFactory
	{
		private static readonly ProxyGenerator proxyGenerator = new ProxyGenerator();

		public static T Create<T>()
		{
			return (T) Create(typeof (T));
		}

		private static object Create(Type type)
		{
			return proxyGenerator.CreateClassProxy(
				type, 
				new[] { typeof(INotifyPropertyChanged) }, 
				new NotifyPropertyChangedInterceptor());
		}
	}
}