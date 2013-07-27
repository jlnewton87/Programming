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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
//Added for powershell stuff
//these are located at: C:\Program Files\Reference Assemblies\Microsoft\WindowsPowerShell\v1.0
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace UnblockFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int flag = 0;
        private string path;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                var dialog = new FolderBrowserDialog();
                DialogResult result = dialog.ShowDialog();
                lblLabel.Content += dialog.SelectedPath;
                path = dialog.SelectedPath;
                btnTheButton.Content = "Unblock Files";
                flag = 1;
            }

            else
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    // create Powershell runspace and open it
                    Runspace runspace = RunspaceFactory.CreateRunspace();
                    runspace.Open();

                    // create a pipeline and feed it the script text
                    Pipeline pipeline = runspace.CreatePipeline();
                    pipeline.Commands.AddScript("Unblock-File " + file);
                }
                System.Windows.MessageBox.Show("Files unblocked!");
            }

        }
    }
}
