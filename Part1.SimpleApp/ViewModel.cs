using System;
using System.Timers;
using BLToolkit.EditableObjects;

namespace Part1.SimpleApp
{
	public abstract class ViewModel : EditableObject<ViewModel>
	{
		private readonly Timer timer;

		protected ViewModel()
		{
			FirstName = "Valeriu";
			LastName = "Caraulean";
			BirthDate = new DateTime(1979, 4, 21);

			timer = new Timer(1000);
			timer.Elapsed += (sender, args) =>
			{
				Alive = (DateTime.Now - BirthDate).TotalSeconds;
			};
			timer.Start();
		}

		public abstract string FirstName { get; set; }
		public abstract string LastName { get; set; }
		public abstract DateTime BirthDate { get; set; }
		public abstract double Alive { get; set; }
	}
}