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
            stop1.Color = FillColor;
            stop1.Offset = val / 5;
            stop2.Color = EmptyColor;
            stop2.Offset = val / 5;
            col.Add(stop1);
            col.Add(stop2);
            LinearGradientBrush brush = new LinearGradientBrush(col, 0);
            Stars.Fill = brush;
         }
      }
      private Color fillColor = Colors.Gold;
      private Color emptyColor = Colors.Black;
      private Color borderColor = Colors.Gold;
       public Color BorderColor
      {
          get { return borderColor; }
          set { borderColor = value; }
      }
      public Color FillColor
      {
          get { return fillColor; }
          set{fillColor = value;}
      }
      public Color EmptyColor
      {
          get { return emptyColor; }
          set { emptyColor = value; }
      }
      public StarRating()
      {
         this.InitializeComponent();
         Value = 0.1;
         Value = 0;
         Stars.Stroke = new SolidColorBrush(borderColor);
      }
   }
}
