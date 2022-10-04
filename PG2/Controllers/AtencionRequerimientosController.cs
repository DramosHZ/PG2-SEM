using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PG2.Controllers
{
    public class AtencionRequerimientosController : Controller
    {
        // GET: AtencionRequerimientos
        public ActionResult AtencionReq()
        {

            var test = new testContext();

            return View(test.);
        }

    }
}