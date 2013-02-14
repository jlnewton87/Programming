using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace JoshsControls
{
   public sealed partial class WaterMarkedCheckBox : UserControl
   {
      private string wm = "Water Mark";
      public string Text
      {
         get{return WMTB.Text;}
         set{WMTB.Text = value;}
      }
      public string WaterMark
      {
         get{return wm;}
         set
         {
            wm = value;
         }
      }

      public WaterMarkedCheckBox()
      {
         this.InitializeComponent();
         
      }

      private void RemoveWaterMark(object sender, RoutedEventArgs e)
      {
         WMTB.Text = "";
         WMTB.Foreground = new SolidColorBrush(Colors.Black);
         WMTB.Background = new SolidColorBrush(Colors.White);
      }

      private void CheckIfWaterMarkNeeded(object sender, RoutedEventArgs e)
      {
         if (WMTB.Text == "")
         {
            WMTB.Foreground = new SolidColorBrush(Colors.DarkGray);
            WMTB.Text = wm;
         }
         else
         {
            WMTB.Background = new SolidColorBrush(Colors.White);
         }
      }
   }
}
