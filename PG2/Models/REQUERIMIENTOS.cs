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
    
    public partial class REQUERIMIENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REQUERIMIENTOS()
        {
            this.PRDR = new HashSet<PRDR>();
            this.REQandDOC = new HashSet<REQandDOC>();
            this.AtencionRequerimiento = new HashSet<AtencionRequerimiento>();
        }
    
        public int Id_Requerimiento { get; set; }
        public string Nombre_Requerimiento { get; set; }
        public string Descripcion_Requerimiento { get; set; }
        public string Area_Requerimiento { get; set; }
        public Nullable<System.DateTime> Fecha_Requerimiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRDR> PRDR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQandDOC> REQandDOC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AtencionRequerimiento> AtencionRequerimiento { get; set; }
    }
}