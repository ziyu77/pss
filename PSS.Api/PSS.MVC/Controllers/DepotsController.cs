using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.MVC.Controllers
{
    public class DepotsController : Controller
    {
        // GET: Depots
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CheckDepot()
        {
            //test
            return View();
        }
    }
}