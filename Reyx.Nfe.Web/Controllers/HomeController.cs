using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.Data;
using Mono.Data.Tds;

namespace Reyx.Nfe.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                using (Database db = Database.Open("Vitec"))
                {
                    ViewBag.agencies = db.Query(" SELECT TOP 100 * FROM Agencies ");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
            }

            return View();
        }
    }
}