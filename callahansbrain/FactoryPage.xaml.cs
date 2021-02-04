using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
			InitializeComponent();
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
		private void ChangeActivePanel(StackPanel newPanel)
		{
			if (activePanel != null)
			{
				activePanel.Visibility = Visibility.Collapsed;
			}
			activePanel = newPanel;
			activePanel.Visibility = Visibility.Visible;
		}
		private void Item_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			if (button.Tag != null && button.Tag.ToString() != string.Empty)
			{
				try
				{
					ItemType itemType = Enum.Parse<ItemType>(button.Tag.ToString());
				}
				catch (Exception exception)
				{
					Debug.WriteLine("[Error] {0}", exception.ToString());
				}
			} else
			{
				Debug.WriteLine("[Error] Wrong button tag in FactoryPage!");
			}
		}
	}
}
