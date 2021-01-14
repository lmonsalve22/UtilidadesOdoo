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
            DivisionAdministrativa div;
            try
            {
                div  = db.divisiones.Where(x => x.id == id3 && x.id2 == id4).First();
            }
            catch (Exception)
            {

                div = new DivisionAdministrativa(1, 1, "Sin división encontrada", "Sin país");
            }
            
            ViewBag.PB = v.urlCompletaGEE(id2);
            ViewBag.GEE = v.urlCompletaPB(id3,id4);
            ViewBag.titulo = div.nombreAdministrativo + " " + div.pais;
            ViewBag.imagen = v.urlImagen;
            return View();
        }
    }
}