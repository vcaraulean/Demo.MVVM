using BLToolkit.EditableObjects;

namespace Part1.Tweaks.Proxy.BLToolkit
{
	public abstract class ViewModel : EditableObject<ViewModel>
	{
		public abstract string SimpleProperty { get; set; }
	}
}