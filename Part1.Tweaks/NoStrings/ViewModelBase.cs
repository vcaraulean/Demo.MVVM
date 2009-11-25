using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Part1.Tweaks.NoStrings
{
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		public virtual event PropertyChangedEventHandler PropertyChanged = delegate { };

		protected virtual void NotifyOfPropertyChange(string propertyName)
		{
			VerifyPropertyName(propertyName);
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		[Conditional("DEBUG")]
		private void VerifyPropertyName(string propertyName)
		{
			if (string.IsNullOrEmpty(propertyName))
				throw new ArgumentException("propertyName cannot be null or empty");

			if (GetType().GetProperty(propertyName) == null)
			{
				const string messageTemplate = "'{0}' is not a valid public property of type '{1}'.";
				string msg = string.Format(messageTemplate, propertyName, GetType().FullName);

				throw new ArgumentException(msg, "propertyName");
			}
		}

		protected virtual void NotifyOfPropertyChange<T>(Expression<Func<T>> propertyExpression)
		{
			var memberExpression = (MemberExpression)propertyExpression.Body;
			string propertyName = memberExpression.Member.Name;
			NotifyOfPropertyChange(propertyName);
		}
	}
}