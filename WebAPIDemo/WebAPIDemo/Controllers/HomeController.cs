using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        //Code Added by prasad 5/28/2017
        public ActionResult TestReport()
        {
            ViewBag.Title = "My First Report";

            return View();
        }

        //Code Added by prasad 5/28/2017
        public ActionResult TestDemoReport()
        {
            ViewBag.Title = "My Demo Report";

            return View();
        }
    }
}
