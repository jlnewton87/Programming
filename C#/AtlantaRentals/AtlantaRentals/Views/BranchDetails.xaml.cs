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
using System.Windows.Shapes;
using AtlantaRentals.Services;

namespace AtlantaRentals.Views
{
    /// <summary>
    /// Interaction logic for BranchDetails.xaml
    /// </summary>
    public partial class BranchDetails : Window
    {
        public BranchDetails()
        {
            DataTable dt = new DataTable();
            using (var connection = DatabaseService.GetAccessConnection())
            {
                connection.Open();
                dt = DatabaseService.GetDataTable("CityList");
                connection.Close();
            }
            InitializeComponent();
            List<string> cities = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                cities.Add(row["City"].ToString());
            }
            cities.Distinct().ToList().ForEach(x => cbCity.Items.Add(x));   
        }

        private void cbCity_Changed(object sender, SelectionChangedEventArgs e)
        {
            string selectedCity = cbCity.SelectedItem.ToString();
            DataTable dt = new DataTable();
            using (var connection = DatabaseService.GetAccessConnection())
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(String.Format(
                    DatabaseService.Queries["BranchDetails"]
                    , selectedCity)
                    , connection);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.SelectCommand = cmd;
                da.Fill(dt);
                dtReport.ItemsSource = dt.DefaultView;
            }
        }
    }
}
