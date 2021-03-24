using AplicacionBlanco.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class MonitoreoController : Controller
    {
        // GET: Monitoreo
        public ActionResult Index(string id = "https://www.bancoestado.cl/imagenes/_personas/home/default.asp")
        {
            EstructuraCritica db = new EstructuraCritica();
            ViewBag.resultado = db.Solicitudes;
            return View();
        }

        public ActionResult Index2()
        {
            /*
            string url = "https://github.com/Sud-Austral/Monitoreo/raw/main/DisponibilidadActualizado.csv";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            var reader = new StreamReader(resp.GetResponseStream());
            List<Solicitud2> salida = new List<Solicitud2>();
            while (!reader.EndOfStream)
            {
                //salida = salida + reader.ReadLine();
                var line = reader.ReadLine();
                var values = line.Split(',');
                salida.Add(new Solicitud2(values[1], values[0], values[2], values[3]));
                //this.ordenes.Add(new Orden(values[9], values[23], values[18]));
                //this.ordenes.Add(new Orden(values[],values[],values[],values[],values[]));
                //string values_r = values[1].Replace("\"", "");
            }
            */
            //ViewBag.resultado = salida;
            return View();
        }


        
        

        
            }
    }