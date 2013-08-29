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
using AtlantaRentals.Models;
using AtlantaRentals.Services;

namespace AtlantaRentals.Views
{
    /// <summary>
    /// Interaction logic for EditBranch.xaml
    /// </summary>
    public partial class EditBranch : Window
    {
        public EditBranch()
        {
            List<int> currentBranchIds = new List<int>();
            DataTable branchNumberDT = DatabaseService.GetDataTable("GetBranchNumbers");
            foreach (DataRow row in branchNumberDT.Rows)
            {
                currentBranchIds.Add(int.Parse(row["BranchNumber"].ToString()));
            }
            InitializeComponent();
            currentBranchIds.ForEach(x => cbBranchToUpdate.Items.Add(x));
            List<int> currentManagerIds = new List<int>();
            DataTable managerTable = DatabaseService.GetDataTable("GetManagerIds");
            foreach (DataRow row in managerTable.Rows)
            {
                currentManagerIds.Add(int.Parse(row["managerId"].ToString()));
            }
            currentManagerIds.ForEach(x => cbManagerIds.Items.Add(x));
        }

        private void btnUpdateBranch_Click(object sender, RoutedEventArgs e)
        {
            using (var connection = DatabaseService.GetAccessConnection())
            {
                string commandString = String.Format(DatabaseService.Queries["UpdateBranch"].ToString()
                    , cbManagerIds.Text
                    , "'" + txtStreet.Text + "'"
                    , "'" + txtCity.Text + "'"
                    , "'" + txtState.Text + "'"
                    , "'" + txtZip.Text + "'"
                    , "'" + txtPhone1.Text + "'"
                    , "'" + txtPhone2.Text + "'"
                    , "'" + txtPhone3.Text + "'"
                    , cbBranchToUpdate.Text
                    );
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(commandString, connection);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.UpdateCommand = cmd;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Branch updated", "Success");
                txtCity.Text = "";
                txtPhone1.Text = "";
                txtPhone2.Text = "";
                txtPhone3.Text = "";
                txtState.Text = "";
                txtStreet.Text = "";
                txtZip.Text = "";
                cbManagerIds.Text = "";
            }

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbBranchToUpdate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox senderObj = (ComboBox)sender;
            int selectedBranchId = int.Parse(senderObj.SelectedItem.ToString());
            List<Branch> branches = DatabaseService.GetBranches();
            Branch selectedBranch = branches.First(x => x.BranchNumber 
                == selectedBranchId);
            txtStreet.Text = selectedBranch.Street;
            txtCity.Text = selectedBranch.City;
            txtState.Text = selectedBranch.State;
            txtZip.Text = selectedBranch.Zip;
            cbManagerIds.Text = selectedBranch.ManagerId;
            txtPhone1.Text = selectedBranch.Phone1;
            txtPhone2.Text = selectedBranch.Phone2;
            txtPhone3.Text = selectedBranch.Phone3;
        }
    }
}
