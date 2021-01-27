using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace callahansbrain
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MassFactoryPage : Page
	{
		public MassFactoryPage()
		{
			this.InitializeComponent();
		}
		private void MainPageClick(object sender, RoutedEventArgs e)
		{
			Button b = (Button)sender;
			throw new NotImplementedException();
			//powrot
		}
		private void FactoryClick(object sender, RoutedEventArgs e)
		{
			Button b = (Button)sender;
			throw new NotImplementedException();
			//ustawia tryb Factory
		}
		private void SmallArmsClick(object sender, RoutedEventArgs e)
		{
			Button b = (Button)sender;
			throw new NotImplementedException();
			//wyswietla buttony od small armsow
		}
		private void HeavyArmsClick(object sender, RoutedEventArgs e)
		{
			Button b = (Button)sender;
			throw new NotImplementedException();
			//wyswietla buttony od heavy armsow
		}
		private void VehicleClick(object sender, RoutedEventArgs e)
		{
			Button b = (Button)sender;
			throw new NotImplementedException();
			//wyswietla buttony od pojazdow
		}
		private void ShippableClick(object sender, RoutedEventArgs e)
		{
			Button b = (Button)sender;
			throw new NotImplementedException();
			//wyswietla buttony od kontenerow
		}
	}
}
