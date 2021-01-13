using AplicacionBlanco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class GEEController : Controller
    {
        // GET: GEE
        public ActionResult Index(int id = 1, int id2 = 1, int id3 = 1, int id4 = 1)
        {
            BaseGEE db = new BaseGEE();
            VistasGEE v = db.vistas.Where(x => x.id == id).First();
            ViewBag.PB = v.urlCompletaGEE(id2);
            ViewBag.GEE = v.urlCompletaPB(id3,id4);
            ViewBag.titulo = v.nombre;
            return View();
        }
    }
}