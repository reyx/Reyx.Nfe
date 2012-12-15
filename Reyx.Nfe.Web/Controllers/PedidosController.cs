using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reyx.Nfe.Web.Controllers
{
    public class PedidosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Digitacao()
        {
            return View();
        }

        public ActionResult Item()
        {
            return PartialView();
        }
    }
}