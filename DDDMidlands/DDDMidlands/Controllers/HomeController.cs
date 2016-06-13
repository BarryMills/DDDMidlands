using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDDMidlands.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult Sessions()
        {
            return View();
        }

        public ActionResult Sponsors()
        {
            return View();
        }


        public ActionResult Speakers()
        {
            return View();
        }

        public ActionResult Venue()
        {
            return View();
        }
    }
}