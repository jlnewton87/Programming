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

      public ActionResult Main()
      {
          ViewBag.Message = "";

          return View();
      }
   }
}
