using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp
{
    public class SurveyQuestion
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public List<SurveyChoice> Choices { get; set; }
    }
}
