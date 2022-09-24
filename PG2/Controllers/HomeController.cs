using PG2.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PG2.Controllers
{
    public class HomeController : Controller
    {
        [AuthorizeUser(IdOperacion: 1)]
        public ActionResult Index()
        {
            return View();
        }
        [AuthorizeUser(IdOperacion: 2)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AuthorizeUser(IdOperacion: 4)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}