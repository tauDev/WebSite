using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewWebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductService()
        {
            return View();
        }
        public ActionResult Inovetion()
        {
            return View();
        }
        public ActionResult InvestorRelations()
        {
            return View();
        }
    }
}