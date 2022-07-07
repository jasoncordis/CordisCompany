using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//The home controller returns views for the Home page, Locations page, and Training page.


namespace CordisCompany.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Locations()
        {
            return View();
        }

        public ActionResult Training()
        {
            return View();
        }
    }
}