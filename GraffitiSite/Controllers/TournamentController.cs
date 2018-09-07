using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraffitiSite.Controllers
{
    public class TournamentController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Registration");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Standings()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}