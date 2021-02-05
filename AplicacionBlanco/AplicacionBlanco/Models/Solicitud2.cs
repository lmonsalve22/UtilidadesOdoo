using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionBlanco.Models
{
    public class Solicitud2
    {
        public string URL { get; set; }
        public string Nombre { get; set; }
        public string Disponibilidad { get; set; }
        public string Fecha { get; set; }

        public Solicitud2(string URL, string Nombre, string Disponibilidad, string Fecha)
        {
            this.URL = URL;
            this.Nombre = Nombre;
            this.Disponibilidad = Disponibilidad;
            this.Fecha = Fecha;
        }
    }
}