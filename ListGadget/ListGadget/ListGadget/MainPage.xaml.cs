using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ListGadget.Resources;
using Net.JoshNewton.Controls;
using ListGadget.ViewModels;
using ListGadget.Data;
using System.Windows.Data;
using System.Threading;
using System.Collections.ObjectModel;

namespace ListGadget
{
    public partial class MainPage : PhoneApplicationPage
    {


        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            App.ViewModel.PropertyChanged += ViewModel_PropertyChanged;
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            DataContext = null;
            DataContext = App.ViewModel;
            LayoutRoot.UpdateLayout();
        }
        
        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void FullList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ItemViewModel)AllList.SelectedItem;
            if (item != null)
            {
                App.ViewModel.Items.Remove(App.ViewModel.Items.Where(x => x == item).Single());
                item.Status = ItemStatus.Complete;
                if (item.ItemComplete)
                {
                    App.ViewModel.Items.Add(new ItemViewModel(item.Description, item.Quantity, item.Status, item.Category));
                }
            }
        }

        private void putItemBack()
        {
            throw new NotImplementedException();
        }

        private void AllListChecked(object sender, RoutedEventArgs e)
        {
            App.ViewModel.Items.Where(x => x.Description == (sender as CheckBox).Name).Single().ItemComplete = true;
        }

        private void AllListUnChecked(object sender, RoutedEventArgs e)
        {
            App.ViewModel.Items.Where(x => x.Description == (sender as CheckBox).Name).Single().ItemComplete = false;
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