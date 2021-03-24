using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class TURNERController : Controller
    {
        // GET: TURNER
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EleccionesCHL()
        {
            return View();
        }
    }
}