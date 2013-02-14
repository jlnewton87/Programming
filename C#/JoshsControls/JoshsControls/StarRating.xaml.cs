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
   public sealed partial class StarRating : UserControl
   {
      private double val;
      public event EventHandler ValueChanged;
      public double Value
      {
         get
         {
            return val;
         }
         set
         {
            val = value;
            GradientStopCollection col = new GradientStopCollection();
            GradientStop stop1 = new GradientStop();
            GradientStop stop2 = new GradientStop();
            stop1.Color = Color.FromArgb(255, 255, 215, 0);
            stop1.Offset = val / 5;
            stop2.Color = Color.FromArgb(255, 0, 0, 0);
            stop2.Offset = val / 5;
            col.Add(stop1);
            col.Add(stop2);
            LinearGradientBrush brush = new LinearGradientBrush(col, 0);
            Stars.Fill = brush;
            OnValueChanged();
         }
      }

      private void OnValueChanged()
      {
         EventHandler localEvent = ValueChanged;
         if (localEvent != null)
         {
            localEvent(this, EventArgs.Empty);
         }
      }

      public StarRating()
      {
         this.InitializeComponent();
      }
   }
}
