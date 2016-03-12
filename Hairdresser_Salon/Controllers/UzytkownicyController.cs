using Hairdresser_Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hairdresser_Salon.Controllers
{
    public class UzytkownicyController : Controller
    {

        projekt_salonuEntities Baza = new projekt_salonuEntities();

        // GET: Uzytkownicy
        public ActionResult Index()
        {
            return View(Baza.Uzytkownicy.ToList());
        }
    }
}