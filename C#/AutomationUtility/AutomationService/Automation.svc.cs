using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AutomationUtility;

namespace AutomationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Automation : IAutomation
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<MenuItem> GetMenu()
        {
            List<MenuItem> output = new List<MenuItem>();
            output.Add(new MenuItem() { Text = "First Item", Id = 1 });
            output.Add(new MenuItem() { Text = "Second Item", Id = 2 });
            output.Add(new MenuItem() { Text = "Third Item", Id = 3 });
            return output;
        }

    }
}
