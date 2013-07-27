using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using joshnewton.net.Models;

namespace joshnewton.net.Controllers
{
    public class TipController : Controller
    {
        //
        // GET: /Tip/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calc()
        {
            TipMatrix matrix = new TipMatrix(Convert.ToDouble(RouteData.Values["id"]));
            ViewData["Matrix"] = matrix;
            return View("DisplayResult");
        }
        public ActionResult Calc2(double p_BillAmount)
        {
            TipMatrix matrix = new TipMatrix(p_BillAmount);
            ViewData["Matrix"] = matrix;
            return View("DisplayResult");
        }
    }
}
