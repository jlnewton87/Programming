using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AutomationUtility.Resources;
using AutomationUtility.AutomationService;

namespace AutomationUtility
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            AutomationClient client = new AutomationClient();
            client.GetMenuCompleted += client_GetMenuCompleted;
            client.GetMenuAsync();
            
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        void client_GetMenuCompleted(object sender, GetMenuCompletedEventArgs e)
        {
            List<MenuItemContainer> source = new List<MenuItemContainer>();
            foreach (var item in e.Result)
            {
                source.Add(new MenuItemContainer(new MenuItem(){Text = item.Text, Id = item.Id}));
            }
            lstMenuItems.ItemsSource = source;
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}