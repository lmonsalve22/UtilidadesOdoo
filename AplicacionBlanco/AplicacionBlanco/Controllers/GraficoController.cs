using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Grafico
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Prueba(string id, string id2)
        {
            ViewBag.URL = id;
            ViewBag.grafico = id2;
            return View();
        }

        public ActionResult Luis1()
        {
            return View();
        }

        public ActionResult Luis2()
        {
            return View();
        }

        public ActionResult Grafico(string id)
        {
            ViewBag.URL = id;
            return View();
        }

        public ActionResult Grafico2(string id)
        {
            ViewBag.URL = id;
        }
        public ActionResult PopUPClent()
        {
            return View();
        }
    }
}