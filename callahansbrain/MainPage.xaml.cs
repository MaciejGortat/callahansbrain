using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace callahansbrain
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
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
	}
}
