//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PG2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AtencionRequerimiento
    {
        public int Id_Atencion { get; set; }
        public string Nombre_Requerimiento { get; set; }
        public string Descripcion_Requerimiento { get; set; }
        public System.DateTime Fecha_Requirimiento { get; set; }
        public string Estatus { get; set; }
        public string Colaborador_Atiende { get; set; }
        public string Encargado_Requerimiento { get; set; }
        public string Solicitante_Requerimiento { get; set; }
        public byte Dependencia_SN { get; set; }
        public string Motivo_Dependencia { get; set; }
        public int Id_Requerimiento { get; set; }
    
        public virtual REQUERIMIENTOS REQUERIMIENTOS { get; set; }
    }
}
