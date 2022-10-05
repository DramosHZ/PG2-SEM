using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PG2.Models.ViewModels
{
    public class ListAtencionReqViewModels
    {

        public int Id_Atencion { get; set; }
        public string Nombre_Requerimiento { get; set; }
        public string Descripcion_Requerimiento { get; set; }
        public System.DateTime Fecha_Requirimiento { get; set; }
        public string Estatus { get; set; }
        public string Colaborador_Atiende { get; set; }
        public string Encargado_Requerimiento { get; set; }
        public string Solicitante_Requerimiento { get; set; }
        public String Dependencia_SN { get; set; }
        public string Motivo_Dependencia { get; set; }
        public int Id_Requerimiento { get; set; }

    }
}