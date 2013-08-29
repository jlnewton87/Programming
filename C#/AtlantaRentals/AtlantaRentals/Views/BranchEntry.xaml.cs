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
    /// Interaction logic for BranchEntry.xaml
    /// </summary>
    public partial class BranchEntry : Window
    {

        public BranchEntry()
        {
            List<int> managerIds = new List<int>();
            DataTable dt = DatabaseService.GetDataTable("GetManagerIds");
            foreach (DataRow row in dt.Rows)
            {
                managerIds.Add(int.Parse(row["managerId"].ToString()));
            }
            InitializeComponent();
            if (managerIds.Count > 0)
            {
                managerIds.ForEach(x => cbManagerIds.Items.Add(x));
            }
        }

        private void btnAddBranch_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtStreet.Text)
                || String.IsNullOrEmpty(txtCity.Text)
                || String.IsNullOrEmpty(txtState.Text)
                || String.IsNullOrEmpty(txtZip.Text)
                || String.IsNullOrEmpty(cbManagerIds.Text))
            {
                MessageBox.Show("Must provide full address and select a manager Id", "Input Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                using(var connection = DatabaseService.GetAccessConnection())
                {
                    string commandString = String.Format(DatabaseService.Queries["InsertNewBranch"]
                        ,"'" + txtStreet.Text + "'"
                        , "'" + txtCity.Text + "'"
                        , "'" + txtState.Text + "'"
                        , "'" + txtZip.Text + "'"
                        , "'" + cbManagerIds.Text + "'");
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand(commandString, 
                        connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
            }
                List<int> currentBranchIds = new List<int>();
                DataTable branchNumberDT = DatabaseService.GetDataTable("GetBranchNumbers");
                foreach (DataRow row in branchNumberDT.Rows)
                {
                    currentBranchIds.Add(int.Parse(row["BranchNumber"].ToString()));
                }
                int newestBranch = currentBranchIds.Max();
                if (!String.IsNullOrEmpty(txtPhone1.Text))
                {
                    addPhoneNumber(txtPhone1.Text, newestBranch);
                    txtPhone1.Text = "";
                }
                if (!String.IsNullOrEmpty(txtPhone2.Text))
                {
                    addPhoneNumber(txtPhone2.Text, newestBranch);
                    txtPhone2.Text = "";
                }
                if (!String.IsNullOrEmpty(txtPhone3.Text))
                {
                    addPhoneNumber(txtPhone3.Text, newestBranch);
                    txtPhone3.Text = "";
                }
                MessageBox.Show("Branch successfully added.", "Branch Added");
                txtStreet.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                txtZip.Text = "";
                cbManagerIds.SelectedIndex = -1;
            }
        }

        private void addPhoneNumber(string p_PhoneNumber, int p_BranchId)
        {
            using (var connection1 = DatabaseService.GetAccessConnection())
            {
                connection1.Open();
                OleDbCommand cmd1 = new OleDbCommand(String.Format(DatabaseService.Queries["InsertBranchPhone"]
                    , p_BranchId
                    ,  "'" + p_PhoneNumber + "'"), connection1);
                cmd1.ExecuteNonQuery();
                connection1.Close();
            }
        }

        private void btnEditBranch_Click(object sender, RoutedEventArgs e)
        {
            var editBranch = new EditBranch();
            editBranch.ShowDialog();
        }
    }
}
