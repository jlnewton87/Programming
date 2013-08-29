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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAddBranch_Click(object sender, RoutedEventArgs e)
        {
            var branchEntry = new BranchEntry();
            branchEntry.ShowDialog();
        }

        private void btnEditBranch_Click(object sender, RoutedEventArgs e)
        {
            var editBranch = new EditBranch();
            editBranch.ShowDialog();
        }

        private void btnAddStaff_Click(object sender, RoutedEventArgs e)
        {
            var staffEntry = new StaffEntry();
            staffEntry.ShowDialog();
        }

        private void btnAddAd_Click(object sender, RoutedEventArgs e)
        {
            var addAd = new AdEntry();
            addAd.ShowDialog();
        }

        private void btnAddRental_Click(object sender, RoutedEventArgs e)
        {
            var addRental = new CurrentlyRented();
            addRental.ShowDialog();
        }

        private void btnAddLease_Click(object sender, RoutedEventArgs e)
        {
            var newLease = new NewLease();
            newLease.ShowDialog();
        }

        private void btnAddManager_Click(object sender, RoutedEventArgs e)
        {
            var addManager = new AddManager();
            addManager.ShowDialog();
        }

        private void btnAddNewspaper_Click(object sender, RoutedEventArgs e)
        {
            var addNewspaper = new AddNewspaper();
            addNewspaper.ShowDialog();
        }

        private void btnAddProperty_Click(object sender, RoutedEventArgs e)
        {
            var addProperty = new AddProperty();
            addProperty.ShowDialog();
        }

        private void btnAddPropertyOwner_Click(object sender, RoutedEventArgs e)
        {
            var addPropertyOwner = new AddPropertyOwner();
            addPropertyOwner.ShowDialog();
        }

        private void btnAddViewing_Click(object sender, RoutedEventArgs e)
        {
            var addViewing = new AddPropertyViewing();
            addViewing.ShowDialog();
        }

        private void btnEditStaff_Click(object sender, RoutedEventArgs e)
        {
            var editStaff = new EditStaff();
            editStaff.ShowDialog();
        }

        private void btnEditAd_Click(object sender, RoutedEventArgs e)
        {
            var editAd = new EditAd();
            editAd.ShowDialog();
        }

        private void btnEditRental_Click(object sender, RoutedEventArgs e)
        {
            var editRental = new EditRental();
            editRental.ShowDialog();
        }

        private void btnEditLease_Click(object sender, RoutedEventArgs e)
        {
            var editLease = new EditLease();
            editLease.ShowDialog();
        }

        private void btnEditManager_Click(object sender, RoutedEventArgs e)
        {
            var editManager = new EditManager();
            editManager.ShowDialog();
        }

        private void btnEditNewspaper_Click(object sender, RoutedEventArgs e)
        {
            var editNewspaper = new EditNewspaper();
            editNewspaper.ShowDialog();
        }

        private void btnEditProperty_Click(object sender, RoutedEventArgs e)
        {
            var editProperty = new EditProperty();
            editProperty.ShowDialog();
        }

        private void btnEditOwner_Click(object sender, RoutedEventArgs e)
        {
            var editOwner = new EditOwner();
            editOwner.ShowDialog();
        }

        private void btnEditViewing_Click(object sender, RoutedEventArgs e)
        {
            var editViewing = new EditViewing();
            editViewing.ShowDialog();
        }

        private void btnDeleteRecords_Click(object sender, RoutedEventArgs e)
        {
            var deleteRecords = new DeleteRecords();
            deleteRecords.ShowDialog();
        }

        private void btnReports_Click(object sender, RoutedEventArgs e)
        {
            var reportMenu = new ReportMenu();
            reportMenu.ShowDialog();
        }
    }
}
