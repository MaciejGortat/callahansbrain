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
		private StackPanel activePanel;
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
		private void ChangeActivePanel(StackPanel newPanel)
		{
			if (activePanel != null)
			{
				activePanel.Visibility = Visibility.Collapsed;
			}
			activePanel = newPanel;
			activePanel.Visibility = Visibility.Visible;
		}
		private void SmallArms_Click(object sender, RoutedEventArgs e)
		{
			ChangeActivePanel(SmallArmsPanel);
		}
		private void HeavyArms_Click(object sender, RoutedEventArgs e)
		{
			ChangeActivePanel(HeavyArmsPanel);
		}
		private void Utility_Click(object sender, RoutedEventArgs e)
		{
			ChangeActivePanel(UtillityPanel);
		}
		private void Medical_Click(object sender, RoutedEventArgs e)
		{
			ChangeActivePanel(MedicalPanel);
		}
		private void Supplies_Click(object sender, RoutedEventArgs e)
		{
			ChangeActivePanel(SupliesPanel);
		}
		private void Item_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			ItemType itemType = ItemType.Parse<ItemType>(button.Tag.ToString());
		}
	}
}
