namespace Part1.Tweaks.NoStrings
{
	public class ViewModel : ViewModelBase
	{
		private string firstProperty;
		private string secondProperty;
		private string thirdProperty;

		public string FirstProperty
		{
			get { return firstProperty; }
			set
			{
				firstProperty = value;
				NotifyOfPropertyChange("FirstProperty");
			}
		}

		public string SecondProperty
		{
			get { return secondProperty; }
			set
			{
				secondProperty = value;
				NotifyOfPropertyChange(() => SecondProperty);
			}
		}

		public string ThirdProperty
		{
			get { return thirdProperty; }
			set
			{
				thirdProperty = value;
				NotifyOfPropertyChange("sdfkjsdh");
			}
		}
	}
}