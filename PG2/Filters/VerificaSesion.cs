
using PG2.Controllers;
using PG2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PG2.Filters
{
    public class VerificaSesion : ActionFilterAttribute
    {
        private Usuario oUser;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);

                oUser = (Usuario)HttpContext.Current.Session["user"];
                if (oUser == null)
                {

                    if (filterContext.Controller is AccesoController == false)
                    {

                        filterContext.HttpContext.Response.Redirect("/Acceso/Login");

                    }

                }
            }
            catch (Exception)
            {
                filterContext.HttpContext.Response.Redirect("~/Acceso/Login");
            }

        }


    }
}