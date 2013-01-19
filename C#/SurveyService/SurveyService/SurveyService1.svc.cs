using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SurveyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SurveyService1 : ISurveyService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool ServerHasSurveys()
        {
            //add code to check the database for surveys saved to this server
            return false;
        }

        public string AddSurveyToServer(string JsonInfoString)
        {
            //add code that takes a JSON string, and creates database structure
            //for new survey
            return "Survey not added.  Incorrect JSON format in request.";
        }

        public string GetSurvey(int surveyId)
        {
            //add code to create/return JSON info string of the survey
            //matching the given ID
            return string.Format("No survey with id matching: {0} could be found.", surveyId);
        }

        public string TestByCreatingADirectory(string name)
        {
            try
            {
                Directory.CreateDirectory(string.Format("C:\\Users\\josh\\Desktop\\{0}", name));
                return string.Format("Folder: {0} created on desktop.", name);
            }
            catch (Exception)
            {
                return "Folder could not be create";
            }
        }
    }
}
