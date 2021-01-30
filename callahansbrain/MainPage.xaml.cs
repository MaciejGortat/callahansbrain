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
			NavigationView nv = (NavigationView)sender;
			//ustawianie domyslanego zaznaczenia
			foreach (NavigationViewItemBase item in TopLevelNav.MenuItems)
			{
				if (item is NavigationViewItem && item.Tag.ToString() == this.GetType().Name.ToString())
				{
					TopLevelNav.SelectedItem = item;
					//przypomnij mi zebym ci wytlumaczyl co tu sie dzieje, jak ogarniasz to usun ten komentarz
					break;
				}
			}
			nv.IsBackEnabled = Frame.CanGoBack;
		}
		private void TopLevelNav_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
		{
			NavigationViewItem Item = (NavigationViewItem)args.InvokedItemContainer;
			string Tag = (string)Item.Tag;
			Dictionary<string, Type> LookupDict = new Dictionary<string, Type>
			{
				{ "MainPage", typeof(MainPage) },
				{ "FactoryPage", typeof(FactoryPage) },
				{ "MassFactoryPage", typeof(MassFactoryPage) }
			};
			this.Frame.Navigate(LookupDict[Tag]);
		}
		private void TopLevelNav_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
		{
			Debug.Write("tutaj");
			if (Frame.CanGoBack)
			{
				Frame.GoBack();
			}
		}
		#endregion
	}
}
