using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SurveyAppClasses;
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

namespace SurveyAppClasses
{
    public sealed partial class QuestionContainer : UserControl
    {

        public QuestionContainer(SurveyQuestion p_targetQuestion)
        {
            this.InitializeComponent();
            QuestionText.Text = p_targetQuestion.Text;
            addChoices(p_targetQuestion);
        }

        private void addChoices(SurveyQuestion p_targetQuestion)
        {
            switch (p_targetQuestion.Type)
            {
                case "radio":
                    foreach (var choice in p_targetQuestion.Choices)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Content = choice.Text;
                        rb.Margin = new Thickness(20);
                        rb.Foreground = new SolidColorBrush(Color.FromArgb(0, 3, 22, 52));
                        this.ChoiceArea.Children.Add(rb);
                    }
                    break;
                case "check":
                    foreach (var choice in p_targetQuestion.Choices)
                    {
                        CheckBox cb = new CheckBox();
                        cb.Content = choice.Text;
                        cb.Margin = new Thickness(20);
                        cb.Foreground = new SolidColorBrush(Color.FromArgb(255, 3, 22, 52));
                        cb.Width = 350;
                        this.ChoiceArea.Children.Add(cb);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
