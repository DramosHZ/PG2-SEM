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
    
    public partial class DOCUMENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCUMENTOS()
        {
            this.REQandDOC = new HashSet<REQandDOC>();
        }
    
        public int Id_Documento { get; set; }
        public string Nombre_Documento { get; set; }
        public string Descripcion_Documento { get; set; }
        public string Path_Documento { get; set; }
        public string Area_Solicitante { get; set; }
        public string Colaborador_Solicitante { get; set; }
        public System.DateTime Fecha_Documento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQandDOC> REQandDOC { get; set; }
    }
}
