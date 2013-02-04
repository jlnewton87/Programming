using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ServiceTestClient.GoDaddyTest;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ServiceTestClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public  MainPage()
        {
            this.InitializeComponent();
        }

        private async void StartService()
        {
            GoDaddyTestClient tc = new GoDaddyTestClient();
            await tc.GetDataAsync(5);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            string message =  txtInput.Text;
            try
            {
                GoDaddyTestClient client = new GoDaddyTestClient();
                message = await client.GetDataAsync(Convert.ToInt32(message));
                ShowMessage(message);
                await client.CloseAsync();
            }
            catch (Exception)
            {

                ShowError();
            }
        }

        private async void ShowMessage(string p_message)
        {
            MessageDialog dialog = new MessageDialog("Message from service: " + p_message);
            await dialog.ShowAsync();
        }

        private void txtGotFocus(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text == "Enter a number")
            {
                txtInput.Text = "";
            }
        }

        private void txtLostFocus(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text == "")
            {
                txtInput.Text = "Enter a number";
            }
        }
        async Task ShowError()
        {
            MessageDialog dialog = new MessageDialog("Something went wrong.\n Try again later.");
            await dialog.ShowAsync();
        }
    }
}
