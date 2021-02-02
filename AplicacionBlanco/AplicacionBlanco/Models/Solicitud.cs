using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using System.Net;

namespace AplicacionBlanco.Models
{
    public class Solicitud
    {
        public string URL { get; set; }
        public string Nombre { get; set; }
        public bool Disponibilidad { get; set; }

        public bool Solicitar(string url)
        {
            //HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            //HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
            //return true;
            
        }

        public Solicitud(string uRL, string nombre)
        {
            URL = uRL;
            Nombre = nombre;
            this.Disponibilidad = Solicitar(this.URL);
        }
    }
}