using System;
using System.Diagnostics;
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
	public sealed partial class FactoryPage : Page
	{
		public FactoryPage()
		{
			this.InitializeComponent();
		}
		#region Navigation event handling
		private void TopLevelNav_Loaded(object sender, RoutedEventArgs e)
		{
			TopLevelNavHandler.OnLoaded((NavigationView)sender, this);
		}
		private void TopLevelNav_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
		{
			TopLevelNavHandler.OnItemInvoked(args, this);
		}
		private void TopLevelNav_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
		{
			TopLevelNavHandler.OnBackRequested(this);
		}
		#endregion
		private void SmallArmsClick(object sender, RoutedEventArgs e)
		{
			SmallArmsPanel.Visibility = Visibility.Visible;
			//wyswietla buttony od small armsow
		}
		private void HeavyArmsClick(object sender, RoutedEventArgs e)
		{
			HeavyArmsPanel.Visibility = Visibility.Visible;
			//wyswietla buttony od heavy armsow
		}
		private void UtilityClick(object sender, RoutedEventArgs e)
		{
			UtillityPanel.Visibility = Visibility.Visible;
			//wyswietla buttony od heavy armsow
		}
		private void MedicalClick(object sender, RoutedEventArgs e)
		{
			MedicalPanel.Visibility = Visibility.Visible;
			//wyswietla buttony od heavy armsow
		}
		private void SuppliesClick(object sender, RoutedEventArgs e)
		{
			SSPanel.Visibility = Visibility.Visible;
			//wyswietla buttony od heavy armsow
		}
	}
}
