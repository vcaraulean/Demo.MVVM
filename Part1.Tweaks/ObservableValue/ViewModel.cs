namespace Part1.Tweaks.ObservableValue
{
	class ViewModel
	{
		public ViewModel()
		{
			BooleanProperty = new Observable<bool>();
			StringProperty = new Observable<string>();
		}

		public Observable<bool> BooleanProperty { get; set;}
		public Observable<string> StringProperty { get; set;}
	}
}