using EventDataService.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventDataService.Controllers
{
    public class GradEventController : Controller
    {

        public string GetData()
        {
            string data;
            using (GraduationEntities ents = new GraduationEntities())
            {
                data = JsonConvert.SerializeObject(ents.Details.ToArray());
            }
            return data;
        }

    }
}
