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
    
    public partial class Operaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operaciones()
        {
            this.RolOperacion = new HashSet<RolOperacion>();
        }
    
        public int idOpe { get; set; }
        public string nomOpe { get; set; }
        public int idMod { get; set; }
    
        public virtual Modulo Modulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolOperacion> RolOperacion { get; set; }
    }
}