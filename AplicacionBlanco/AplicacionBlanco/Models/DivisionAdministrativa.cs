using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionBlanco.Models
{
    public class DivisionAdministrativa
    {
        public int id { get; set; }
        public int id2 { get; set; }
        public string nombreAdministrativo { get; set; }
        public string pais { get; set; }

        public DivisionAdministrativa(int id, int id2, string nombreAdministrativo, string pais)
        {
            this.id = id;
            this.id2 = id2;
            this.nombreAdministrativo = nombreAdministrativo;
            this.pais = pais;
        }
    }
}