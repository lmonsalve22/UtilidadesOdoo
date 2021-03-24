using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class RedesController : Controller
    {
        public ActionResult EleccionesRedesHN()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();
        }
    }
}