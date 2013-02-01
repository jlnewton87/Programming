using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace joshnewton.net.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         ViewBag.Message = "Where it all begins.";

         return View();
      }

      public ActionResult About()
      {
         ViewBag.Message = "Ideas.";

         return View();
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "";

         return View();
      }
   }
}
