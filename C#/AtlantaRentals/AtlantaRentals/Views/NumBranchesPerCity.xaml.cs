using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for NumBranchesPerCity.xaml
    /// </summary>
    public partial class NumBranchesPerCity : Window
    {
        public NumBranchesPerCity()
        {
            DataTable dt = new DataTable();
            using (var connection = DatabaseService.GetAccessConnection())
            {
                connection.Open();
                dt = DatabaseService.GetDataTable("NumBranchesPerCity");
                connection.Close();
            }
            InitializeComponent();
            dtReport.ItemsSource = dt.DefaultView;
        }
    }
}
