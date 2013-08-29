using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AtlantaRentals.Views;

namespace AtlantaRentals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //string userType = (String.IsNullOrEmpty(cbUserType.SelectedValue.ToString())) ? "" : cbUserType.Text;
            var mainMenu = new AtlantaRentals.Views.Menu();
            mainMenu.Show();
            this.Close();
            //var newW = new NewWindow();
            //newW.Show();
        }

            //var connection = DatabaseService.GetAccessConnection();
            //connection.Open();
            //OleDbCommand cmd = new OleDbCommand(DatabaseService.Queries["GetNewspapers"], connection);
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            //dgTest.ItemsSource = dt.DefaultView;
    }
}
