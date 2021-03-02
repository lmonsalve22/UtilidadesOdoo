using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionBlanco.Models
{
    public class EstructuraCritica
    {
        public List<Solicitud> Solicitudes { get; set; }

        public EstructuraCritica()
        {
            Solicitudes = new List<Solicitud>();
            Solicitudes.Add(new Solicitud("https://www.dataintelligence-group.com/", "Odoo"));
            Solicitudes.Add(new Solicitud("https://www.dataintelligence-group.com/", "Odoo"));
            Solicitudes.Add(new Solicitud("https://www.dataintelligence-group.com/", "Odoo"));
            Solicitudes.Add(new Solicitud("https://www.dataintelligence-group.com/", "Odoo"));
            Solicitudes.Add(new Solicitud("https://www.dataintelligence-group.com/", "Odoo"));
            Solicitudes.Add(new Solicitud("https://www.dataintelligence-group.com/", "Odoo"));
            Solicitudes.Add(new Solicitud("https://www.dataintelligence-group.com/", "Odoo"));
        }
    }
}