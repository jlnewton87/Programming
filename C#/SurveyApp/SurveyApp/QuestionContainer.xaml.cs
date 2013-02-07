using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SurveyAppClasses;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace CustomControlTester
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
                        this.ChoiceArea.Children.Add(rb);
                    }
                    break;
                case "check":
                    foreach (var choice in p_targetQuestion.Choices)
                    {
                        CheckBox cb = new CheckBox();
                        cb.Content = choice.Text;
                        cb.Margin = new Thickness(20);
                        this.ChoiceArea.Children.Add(cb);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
