using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PG2.Models.ViewModels
{
    public class CRUDAtencionRequerimientos
    {
        public int Id_Atencion { get; set; }
        [Required]
        [Display(Name = "Nombre del Requerimiento")]
        public string Nombre_Requerimiento { get; set; }
        [Required]
        [Display(Name = "Descripcion del Requerimiento")]
        public string Descripcion_Requerimiento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha del Requerimiento")]
        public System.DateTime Fecha_Requirimiento { get; set; }
        [Required]
        [Display(Name = "Estatus del Requerimiento")]
        public string Estatus { get; set; }
        [Required]
        [Display(Name = "Colaborador Responsable")]
        public string Colaborador_Atiende { get; set; }
        [Required]
        [Display(Name = "Encargado del Requerimiento")]
        public string Encargado_Requerimiento { get; set; }
        [Required]
        [Display(Name = "Solicitante del Requerimiento")]
        public string Solicitante_Requerimiento { get; set; }
        [Required]
        [Display(Name = "Dependencia del Requerimiento")]
        public string Dependencia_SN { get; set; }
        [Required]
        [Display(Name = "Motivo de dependencia")]
        public string Motivo_Dependencia { get; set; }
        public int Id_Requerimiento { get; set; }
        [Required]
        [Display(Name = "Area del Requerimiento")]
        public string Area_Requerimiento { get; set; }

    }

}