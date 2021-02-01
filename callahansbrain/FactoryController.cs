using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace callahansbrain
{
	class FactoryController
	{
		private FactoryController(){}
		private static FactoryController instance = null;
		public static FactoryController Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new FactoryController();
				}
				return instance;
			}
		}
		public Facility SelectedFacility{ get; private set; }
	}
}
