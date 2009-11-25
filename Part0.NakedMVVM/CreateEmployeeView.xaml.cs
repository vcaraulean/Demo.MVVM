using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Part0.NakedMVVM
{
	public partial class CreateEmployeeView : Window
	{
		public CreateEmployeeView()
		{
			InitializeComponent();
			DataContext = new CreateEmployeeViewModel();   
		}
	}
}