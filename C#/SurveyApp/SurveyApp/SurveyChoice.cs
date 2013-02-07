using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SurveyAppClasses
{
    public class SurveyChoice
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public int Value { get; set; }
    }
}
