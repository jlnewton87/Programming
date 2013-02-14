using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClasses
{
    public class SurveyHelper
    {
        public List<SurveyQuestion> Questions = new List<SurveyQuestion>();
        public SurveyHelper()
        {
            generateTestData();
        }

        private void generateTestData()
        {
            for (int i = 0; i < 10; i++)
            {
                SurveyQuestion newQuestion = new SurveyQuestion();
                newQuestion.Id = i;
                newQuestion.Type = "check";
                newQuestion.Text = String.Format("This is a question: #{0}", i);
                newQuestion.Choices = new List<SurveyChoice>();
                for (int j = 0; j < 20; j++)
                {
                    Random ran = new Random();
                    int random = ran.Next(0, 100);
                    SurveyChoice newChoice = new SurveyChoice();
                    newChoice.Id = j;
                    newChoice.Text = String.Format("This is a choice:#{0}", j);
                    newChoice.QuestionId = i;
                    newChoice.Value = random;
                    newQuestion.Choices.Add(newChoice);
                }
                Questions.Add(newQuestion);
            }
        }
    }
}
