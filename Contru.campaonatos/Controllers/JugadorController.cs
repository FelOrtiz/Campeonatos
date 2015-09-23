using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contru.campaonatos.Controllers
{
    public class JugadorController : Controller
    {
        //
        // GET: /Jugador/

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Teams()
        {
            return View();
        }
        public ActionResult Tournaments()
        {
            return View();
        }
    }
}
