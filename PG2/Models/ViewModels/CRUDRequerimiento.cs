using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PG2.Models.ViewModels
{
    public class CRUDRequerimiento
    {

        public int Id_Requerimiento { get; set; }
        [Required]
        [Display(Name = "Nombre del Requerimiento")]
        public string Nombre_Requerimiento { get; set; }
        [Required]
        [Display(Name = "Descripcion del Requerimiento")]
        public string Descripcion_Requerimiento { get; set; }
        [Required]
        [Display(Name = "Area del Requerimiento")]
        public string Area_Requerimiento { get; set; }
        [Required]
        [Display(Name = "Fecha del Requerimiento")]
        public System.DateTime Fecha_Requirimiento { get; set; }

    }
}