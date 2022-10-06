using PG2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PG2.Filters
{   
    [AttributeUsage(AttributeTargets.Method, AllowMultiple =false)]
    public class AuthorizeUser : AuthorizeAttribute
    {
        private Usuario oUser;
        private SEGEXCAEntities db = new SEGEXCAEntities();
        private int IdOperacion;

        public AuthorizeUser(int IdOperacion = 0) {

            this.IdOperacion = IdOperacion;
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {

            string NombreOperacion  ="";
            string NombreModulo  ="";

            try
            {
                oUser = (Usuario)HttpContext.Current.Session["user"];
                var lstMisOperaciones = from j in db.RolOperacion
                                        where j.idRol == oUser.idRol && j.idOpe == IdOperacion
                                        select j;

                if (lstMisOperaciones.ToList().Count() == 0) {

                    var oOperacion = db.Operaciones.Find(IdOperacion);
                    NombreOperacion = getnomOpe(IdOperacion);
                    int? idModulo = oOperacion.idMod;
                    NombreModulo = getNombreDelModulo(idModulo);
                    filterContext.Result = new RedirectResult("~/Error/UnauthorizedOperation?operacion=" + NombreOperacion, "~/Error/UnauthorizedOperation?modulo=" + NombreModulo) ;
                         
                
                }
            }
            catch (Exception)
            { 

                filterContext.Result = new RedirectResult("~/Error/UnauthorizedOperation?Operacion=" + NombreOperacion + NombreModulo);
            }
        }

        private string getNombreDelModulo(int? idModulo)
        {
            var mod = from mo in db.Modulo
                      where mo.idMod == idModulo
                      select mo.nomMod;
            string nombreModulo;
            try
            {
                nombreModulo = mod.First();
            }
            catch (Exception)
            {
                nombreModulo = " ";
            }

            return nombreModulo;
        }

        private string getnomOpe(int IdOperacion)
        {
            var ope = from op in db.Operaciones
                      where op.idOpe == IdOperacion
                      select op.nomOpe;
            string nombreOperacion;
            try
            {
                nombreOperacion = ope.First();
            }
            catch (Exception)
            {
                nombreOperacion = " ";
            }

            return nombreOperacion;
        }
    }
}