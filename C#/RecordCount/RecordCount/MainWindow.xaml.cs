using System;
using System.Collections.Generic;
using System.IO;
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

namespace RecordCount
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FileCount> fileCounts = new List<FileCount>();
        public bool hasHeaders = false;
        public MainWindow()
        {
            InitializeComponent();
            dgRowCounts.ItemsSource = fileCounts;
            dgRowCounts.ColumnWidth = dgRowCounts.Width / 2;
        }

        private void fileDropped(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                {
                    if (File.Exists(fileLoc))
                    {
                        bool isInList = fileCounts.Any(i => i.FileName == System.IO.Path.GetFileName(fileLoc));
                        if (!isInList)
                        {
                            FileCount file = new FileCount(fileLoc, hasHeaders);
                            fileCounts.Add(file);
                            dgRowCounts.Items.Refresh();
                        }
                    }

                }
            }
        }

        private void noHeaders(object sender, RoutedEventArgs e)
        {
            hasHeaders = false;
            foreach (var file in fileCounts)
            {
                int oldCount = Convert.ToInt32(file.Count);
                int newCount = oldCount + 1;
                file.Count = newCount.ToString();
                dgRowCounts.Items.Refresh();
            }
        }

        private void withHeaders(object sender, RoutedEventArgs e)
        {
            hasHeaders = true;
            foreach (var file in fileCounts)
            {
                int oldCount = Convert.ToInt32(file.Count);
                int newCount = oldCount - 1;
                file.Count = newCount.ToString();
                dgRowCounts.Items.Refresh();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fileCounts.Clear();
            dgRowCounts.Items.Refresh();
        }
    }
}
