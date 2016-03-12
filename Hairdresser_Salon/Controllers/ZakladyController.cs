using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hairdresser_Salon.Controllers
{
    public class ZakladyController : Controller
    {
        projekt_salonuEntities Baza = new projekt_salonuEntities();

        // GET: Zaklady
        public ActionResult Index()
        {
            return View(Baza.ZakladyFryzjerskie.ToList());
        }

        

    }
}