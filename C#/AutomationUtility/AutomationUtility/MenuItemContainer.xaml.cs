using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace AutomationUtility
{
    public partial class MenuItemContainer : UserControl
    {
        public MenuItem MyMenuItem;
        public MenuItemContainer(MenuItem p_item)
        {
            InitializeComponent();
            menuItemText.Text = p_item.Text;
            MyMenuItem = p_item;
        }

        private void Alert(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show(String.Format("Item: {0}  selected!", MyMenuItem.Id));
        }
    }
}
