using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class RedireccionController : Controller
    {
        // GET: Redireccion
        public ActionResult Index(string id)
        {
            if(id == "Hola")
            {
                //return View("Index2",id);
                ViewBag.pass = id;
                Session["id"] = id;
                Session.Timeout = 1;
                return View();
            }
            //return View();
            //return RedirectToAction("Index2");
            //return View("Index2");
            return View("Error");
        }

        public ActionResult Index2()
        {
            try
            {
                ViewBag.pass = Session["id"];
            }
            catch (Exception)
            {

                ViewBag.pass = "";
                return View("Error");
            }
            return View();

        }

        public ActionResult Index3()
        {
            return View();

        }

        public ActionResult Index4()
        {
            return View();

        }

        public ActionResult Error()
        {
            return View();
        }
    }
}