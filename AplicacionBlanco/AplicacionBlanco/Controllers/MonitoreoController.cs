using AplicacionBlanco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Logs
            {

        this.ordenes = new List<Orden>();
            string url = "https://github.com/Sud-Austral/Monitoreo/raw/main/DisponibilidadActualizado.csv";

        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        var reader = new StreamReader(resp.GetResponseStream());

        List<string> listA = new List<string>();
        List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
        var values = line.Split(',');
                this.ordenes.Add(new Orden(values[9], values[23], values[18]));
                //this.ordenes.Add(new Orden(values[],values[],values[],values[],values[]));
                //string values_r = values[1].Replace("\"", "");
                }
            }
    }
}