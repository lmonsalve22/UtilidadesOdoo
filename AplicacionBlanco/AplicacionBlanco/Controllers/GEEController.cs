﻿using AplicacionBlanco.Models;
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
            VistasGEE v = db.vistas.Where(x => x.id == id && x.id2 == id2).First();
            /*
            DivisionAdministrativa div;
            try
            {
                div  = db.divisiones.Where(x => x.id == id3 && x.id2 == id4).First();
            }
            catch (Exception)
            {

                div = new DivisionAdministrativa(1, 1, "Sin división encontrada", "Sin país");
            }
            */
            DivisionAdministrativa div = new DivisionAdministrativa(1, 1, "Sin división encontrada", "Sin país");
            ViewBag.PB = v.urlPowerBi;
            ViewBag.GEE = v.geeURL;
            ViewBag.titulo = div.nombreAdministrativo + " " + div.pais;
            ViewBag.imagen = v.urlImagen;
            ViewBag.HTMLTitulo = v.nombre;
            return View();
        }
    }
}