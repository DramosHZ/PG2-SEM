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

        public ActionResult Guardar() {

            return View();

        }

        [HttpPost]
        public ActionResult Guardar(CRUDAtencionRequerimientos modelAR)
        {
            try
            {

                if (ModelState.IsValid) {

                    using (Models.PROandDOCEntities db = new PROandDOCEntities()) {

                        var rTabla = new REQUERIMIENTOS();

                        rTabla.Nombre_Requerimiento = modelAR.Nombre_Requerimiento;
                        rTabla.Descripcion_Requerimiento = modelAR.Descripcion_Requerimiento;
                        rTabla.Area_Requerimiento = modelAR.Area_Requerimiento;
                        rTabla.Fecha_Requerimiento = modelAR.Fecha_Requirimiento;
                        db.REQUERIMIENTOS.Add(rTabla);
                        db.SaveChanges();

                        var oIdRequerimiento = (from u in db.REQUERIMIENTOS
                                 where u.Nombre_Requerimiento == modelAR.Nombre_Requerimiento && u.Descripcion_Requerimiento == modelAR.Descripcion_Requerimiento
                                 && u.Area_Requerimiento == modelAR.Area_Requerimiento && u.Fecha_Requerimiento == modelAR.Fecha_Requirimiento
                                 select u).FirstOrDefault();

                    if (modelAR.Dependencia_SN.Equals("SI"))
                    {

                        String numero = "1";

                        modelAR.Dependencia_SN = numero;
                    }
                    else {

                        String numero = "2";

                        modelAR.Dependencia_SN = numero;
                    }

                        var oTabla = new AtencionRequerimiento();

                        oTabla.Nombre_Requerimiento =modelAR.Nombre_Requerimiento;
                        oTabla.Descripcion_Requerimiento =modelAR.Descripcion_Requerimiento;
                        oTabla.Fecha_Requirimiento =modelAR.Fecha_Requirimiento;
                        oTabla.Estatus = modelAR.Estatus;
                        oTabla.Colaborador_Atiende = modelAR.Colaborador_Atiende;
                        oTabla.Encargado_Requerimiento = modelAR.Encargado_Requerimiento;
                        oTabla.Solicitante_Requerimiento = modelAR.Solicitante_Requerimiento;
                        oTabla.Dependencia_SN = byte.Parse(modelAR.Dependencia_SN);
                        oTabla.Motivo_Dependencia =modelAR.Motivo_Dependencia;
                        oTabla.Id_Requerimiento = oIdRequerimiento.Id_Requerimiento;

                        db.AtencionRequerimiento.Add(oTabla);
                        db.SaveChanges();

                    }

                    return Redirect("Index");
                }

                return View(modelAR);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



        public ActionResult Editar(int Id)
        {
            CRUDAtencionRequerimientos modelAR = new CRUDAtencionRequerimientos();
            using (PROandDOCEntities db = new PROandDOCEntities()) {

                var oTabla = db.AtencionRequerimiento.Find(Id);

                modelAR.Nombre_Requerimiento = oTabla.Nombre_Requerimiento;
                modelAR.Descripcion_Requerimiento = oTabla.Descripcion_Requerimiento;
                modelAR.Fecha_Requirimiento = oTabla.Fecha_Requirimiento;
                modelAR.Estatus = oTabla.Estatus;
                modelAR.Colaborador_Atiende = oTabla.Colaborador_Atiende;
                modelAR.Encargado_Requerimiento = oTabla.Encargado_Requerimiento;
                modelAR.Solicitante_Requerimiento = oTabla.Solicitante_Requerimiento;

                if (oTabla.Dependencia_SN == 1) {

                    string dependencia_sn = "SI";
                    modelAR.Dependencia_SN = dependencia_sn;

                }
                else {
                    string dependencia_sn = "NO";
                    modelAR.Dependencia_SN = dependencia_sn;

                }

                modelAR.Motivo_Dependencia = oTabla.Motivo_Dependencia;
                modelAR.Id_Atencion = oTabla.Id_Atencion;
                modelAR.Id_Requerimiento = oTabla.Id_Requerimiento;

                var oTablaR = db.REQUERIMIENTOS.Find(oTabla.Id_Requerimiento);

                modelAR.Area_Requerimiento = oTablaR.Area_Requerimiento;


                ViewData["Titulo_req"] = oTabla.Nombre_Requerimiento;

            }
                return View(modelAR);

        }

        [HttpPost]
        public ActionResult Editar(CRUDAtencionRequerimientos modelAR)
        {
            try
            {

                if (ModelState.IsValid) {

                    using (Models.PROandDOCEntities db = new PROandDOCEntities()) {

                        var rTabla = db.REQUERIMIENTOS.Find(modelAR.Id_Requerimiento);
                        rTabla.Nombre_Requerimiento = modelAR.Nombre_Requerimiento;
                        rTabla.Descripcion_Requerimiento = modelAR.Descripcion_Requerimiento;
                        rTabla.Area_Requerimiento = modelAR.Area_Requerimiento;
                        rTabla.Fecha_Requerimiento = modelAR.Fecha_Requirimiento;
                        db.Entry(rTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        var oIdRequerimiento = (from u in db.REQUERIMIENTOS
                                                where u.Nombre_Requerimiento == modelAR.Nombre_Requerimiento && u.Descripcion_Requerimiento == modelAR.Descripcion_Requerimiento
                                                && u.Area_Requerimiento == modelAR.Area_Requerimiento && u.Fecha_Requerimiento == modelAR.Fecha_Requirimiento
                                                select u).FirstOrDefault();

                        if (modelAR.Dependencia_SN.Equals("SI"))
                        {

                            String numero = "1";

                            modelAR.Dependencia_SN = numero;
                        }
                        else
                        {

                            String numero = "2";

                            modelAR.Dependencia_SN = numero;
                        }

                        var oTabla = db.AtencionRequerimiento.Find(modelAR.Id_Atencion);
                        oTabla.Nombre_Requerimiento = modelAR.Nombre_Requerimiento;
                        oTabla.Descripcion_Requerimiento = modelAR.Descripcion_Requerimiento;
                        oTabla.Fecha_Requirimiento = modelAR.Fecha_Requirimiento;
                        oTabla.Estatus = modelAR.Estatus;
                        oTabla.Colaborador_Atiende = modelAR.Colaborador_Atiende;
                        oTabla.Encargado_Requerimiento = modelAR.Encargado_Requerimiento;
                        oTabla.Solicitante_Requerimiento = modelAR.Solicitante_Requerimiento;
                        oTabla.Dependencia_SN = byte.Parse(modelAR.Dependencia_SN);
                        oTabla.Motivo_Dependencia = modelAR.Motivo_Dependencia;
                        oTabla.Id_Requerimiento = modelAR.Id_Requerimiento;

                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }

                    return Redirect("/Home/Index");
                }

                return View(modelAR);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}