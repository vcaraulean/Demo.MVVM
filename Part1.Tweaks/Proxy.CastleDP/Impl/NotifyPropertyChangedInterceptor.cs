using System.ComponentModel;
using Castle.Core.Interceptor;

namespace Part1.Tweaks.Proxy.CastleDP.Impl
{
	public class NotifyPropertyChangedInterceptor : IInterceptor
	{
		private PropertyChangedEventHandler subscribers = delegate { };
		public void Intercept(IInvocation invocation)
		{
			if (invocation.Method.DeclaringType == typeof(INotifyPropertyChanged))
			{
				var propertyChangedEventHandler = (PropertyChangedEventHandler)invocation.Arguments[0];
				if (invocation.Method.Name.StartsWith("add_"))
				{
					subscribers += propertyChangedEventHandler;
				}
				else
				{
					subscribers -= propertyChangedEventHandler;
				}
				return;
			}

			invocation.Proceed();

			if (invocation.Method.Name.StartsWith("set_"))
			{
				var propertyName = invocation.Method.Name.Substring(4);
				subscribers(invocation.InvocationTarget, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}