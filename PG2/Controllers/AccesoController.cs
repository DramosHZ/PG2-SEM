using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PG2.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string pass) 
        {

            try
            {

                using (Models.SEGEXCAEntities db = new Models.SEGEXCAEntities()) {

                    var oUser = (from u in db.Usuario
                                 where u.emailUser == user.Trim() && u.passUser == pass.Trim()
                                 select u).FirstOrDefault();

                    if (oUser == null) {

                        ViewBag.Error = "Usuario o contraseña invalida";
                        return View();
                        
                    }

                    Session["user"] = oUser;
                
                }

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {

                ViewBag.Error = ex.Message;

                return View();

            }

        }
    }
}