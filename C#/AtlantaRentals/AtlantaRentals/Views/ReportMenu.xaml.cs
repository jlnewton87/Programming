using System;
using System.Collections.Generic;
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

namespace AtlantaRentals.Views
{
    /// <summary>
    /// Interaction logic for ReportMenu.xaml
    /// </summary>
    public partial class ReportMenu : Window
    {
        public ReportMenu()
        {
            InitializeComponent();
        }

        private void btnBranchCityReport_Click(object sender, RoutedEventArgs e)
        {
            var branchDetails = new BranchDetails();
            branchDetails.ShowDialog();
        }
        private void btnNumBranches_Click(object sender, RoutedEventArgs e)
        {
            var numBranches = new NumBranchesPerCity();
            numBranches.ShowDialog();
        }
    }
}
