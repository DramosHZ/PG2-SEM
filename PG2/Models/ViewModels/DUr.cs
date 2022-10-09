using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PG2.Models.ViewModels
{
    public class DUr
    {

        public int idUser { get; set; }
        public string nomUser { get; set; }
        public string emailUser { get; set; }
        public System.DateTime fechaUser { get; set; }
        public string passUser { get; set; }
        public System.DateTime fechapassUser { get; set; }
        public int idRol { get; set; }
        public virtual Rol Rol { get; set; }

    }

}