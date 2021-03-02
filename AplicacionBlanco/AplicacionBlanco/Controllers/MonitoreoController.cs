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
    }
}