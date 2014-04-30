using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Markup;

namespace Net.JoshNewton.Controls
{
    [ContentPropertyAttribute("Content")]
    public partial class LoadingCurtain : UserControl
    {
        public LoadingCurtain()
        {
            InitializeComponent();
            LoaderAnimation.Begin();
        }
        public void Show()
        {
            LayoutRoot.Visibility = Visibility.Visible;
        }

        public void Hide()
        {
            LayoutRoot.Visibility = Visibility.Collapsed;
        }
    }
}
