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
            CreateControls();
        }

        private void CreateControls()
        {
			// Initialize a new Button control
			Button button1 = new Button
			{
				// Set button content
				Content = "Click Me",

				// Set button height and width
				Width = 200,
				Height = 75
			};

			// Add a click event
			button1.Click += Button1_Click;

            // Add the newly created button control to the stack panel
            grid1.Children.Add(button1);
        }

        // Handle the button click event
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            b.Content = "Clicked";
        }
    }
}
