using Caliburn.Core;

namespace Part2.CaliburnDemo.ViewModels
{
	public class ShellViewModel : PropertyChangedBase
	{
		private string _message;

		public ShellViewModel()
		{
			Message = "My First Message";
		}

		public string Message
		{
			get { return _message; }
			set
			{
				_message = value;
				NotifyOfPropertyChange("Message");
			}
		}

		public void ChangeMessage()
		{
			Message = "Hello World";
		}   
	}
}