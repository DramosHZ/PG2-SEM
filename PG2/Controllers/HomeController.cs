using PG2.Filters;
using PG2.Models;
using PG2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PG2.Controllers
{
    public class HomeController : Controller
    {
        

        [AuthorizeUser(IdOperacion: 2)]
        public ActionResult Index()
        {
            Usuario ooUser;
            
            ooUser = (Usuario)HttpContext.Session["user"];

            ViewBag.Mensaje = ooUser.nomUser;

            List<ListAtencionReqViewModels> lst;

            using (Models.PROandDOCEntities db = new Models.PROandDOCEntities())
            {

                lst = (from d in db.AtencionRequerimiento
                       select new ListAtencionReqViewModels
                       {
                           Id_Atencion = d.Id_Atencion,
                           Id_Requerimiento = d.Id_Requerimiento,
                           Nombre_Requerimiento = d.Nombre_Requerimiento,
                           Descripcion_Requerimiento = d.Descripcion_Requerimiento,
                           Fecha_Requirimiento = d.Fecha_Requirimiento,
                           Estatus = d.Estatus,
                           Colaborador_Atiende = d.Colaborador_Atiende,
                           Dependencia_SN = d.Dependencia_SN.ToString(),
                           Motivo_Dependencia = d.Motivo_Dependencia

                       }).ToList();

            }

            return View(lst);
        }
        [AuthorizeUser(IdOperacion: 4)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AuthorizeUser(IdOperacion: 5)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}