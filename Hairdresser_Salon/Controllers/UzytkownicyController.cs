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
        Uzytkownicy _uzytkownicy;

        // GET: Uzytkownicy
        public ActionResult Index()
        {
            this._uzytkownicy = new Uzytkownicy(1);
            
            return View();
        }
    }
}