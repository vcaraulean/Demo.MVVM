using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using Caliburn.PresentationFramework.ApplicationModel;
using Part2.CaliburnDemo.ViewModels;

namespace Part2.CaliburnDemo
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : CaliburnApplication
	{
		public App()
		{
			InitializeComponent();
		}

		protected override object CreateRootModel()
		{
			return new ShellViewModel();
		}
	}
}
