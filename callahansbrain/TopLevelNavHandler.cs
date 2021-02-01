using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Animation;

namespace callahansbrain
{
	public static class TopLevelNavHandler
	{
		public static void OnLoaded<T>(NavigationView nv, T page) where T : Page
		{
			//ustawianie domyslanego zaznaczenia
			foreach (NavigationViewItemBase item in nv.MenuItems)
			{
				if (item is NavigationViewItem && item.Tag.ToString() == page.GetType().Name.ToString())
				{
					nv.SelectedItem = item;
					//przypomnij mi zebym ci wytlumaczyl co tu sie dzieje, jak ogarniasz to usun ten komentarz
					break;
				}
			}
			nv.IsBackEnabled = page.Frame.CanGoBack;
		}
		public static void OnItemInvoked(NavigationViewItemInvokedEventArgs args, Page page)
		{
			NavigationViewItem Item = (NavigationViewItem)args.InvokedItemContainer;
			string Tag = (string)Item.Tag;
			Dictionary<string, Type> LookupDict = new Dictionary<string, Type>
			{
				{ "MainPage", typeof(MainPage) },
				{ "FactoryPage", typeof(FactoryPage) },
				{ "MassFactoryPage", typeof(MassFactoryPage) }
			};
			page.Frame.Navigate(LookupDict[Tag], null, new SuppressNavigationTransitionInfo());
		}
		public static void OnBackRequested(Page page)
		{
			if (page.Frame.CanGoBack)
			{
				page.Frame.GoBack();
			}
		}
	}
}
