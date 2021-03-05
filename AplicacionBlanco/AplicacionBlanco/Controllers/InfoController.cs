using AplicacionBlanco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class InfoController : Controller
    {
        public InfoController()
        {
            
        }

        // GET: Info
        public ActionResult Index(int id = 1, string id2 = "grafico")
        {
            ViewBag.grafico = id2;
            Graficos db = new Graficos();
            ViewBag.Resultado = db.BuscarGrafico(id);
            return View();
        }

        public ActionResult prueba2()
        {
          
            return View();
        }
    }
}