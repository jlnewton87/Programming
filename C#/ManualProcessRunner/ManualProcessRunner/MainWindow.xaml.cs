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

namespace ManualProcessRunner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MouseDown += delegate{DragMove();};
            InitializeComponent();
            btnExit.IsCancel = true;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HoverX(object sender, MouseEventArgs e)
        {
            btnX.Foreground = Brushes.Red;
            btnX.Background = Brushes.White;
        }

        private void HoverOffX(object sender, MouseEventArgs e)
        {
            btnX.Foreground = Brushes.White;
            btnX.Background = Brushes.Red;
        }
    }
}
