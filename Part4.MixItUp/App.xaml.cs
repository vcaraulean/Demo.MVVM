using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using BLToolkit.Reflection;
using Caliburn.PresentationFramework.ApplicationModel;

namespace Part4.MixItUp
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : CaliburnApplication
	{
		private void AddAlias()
		{
			var viewSteategy = Container.GetInstance<IViewStrategy>() as DefaultViewStrategy;

			if (viewSteategy != null)
				viewSteategy.AddNamespaceAlias("Part4.MixItUp.Views.BLToolkitExtension", "Part4.MixItUp.Views");
		}

		protected override object CreateRootModel()
		{
			return new ViewModels.Naked_CreateEmployeeViewModel();

//			AddAlias();
//			return TypeAccessor.CreateInstance<ViewModels.CreateEmployeeViewModel>();
		}
	}
}
