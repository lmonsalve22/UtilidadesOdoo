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

        //public ActionResult Index2(int id = 1, string id2 = "grafico")
        public ActionResult Index2(int id = 1, string id2 = "mapadechile_engeochart_2021.csv")
        {
            ViewBag.grafico = id2;
            Graficos db = new Graficos();
            ViewBag.Resultado = db.BuscarGrafico(id);
            return View();
        }
    }
}