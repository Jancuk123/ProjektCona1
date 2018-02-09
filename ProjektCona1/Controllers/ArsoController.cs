using ProjektCona1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektCona1.Controllers
{
    public class ArsoController : Controller
    {
        // GET: Arso
        public ActionResult Index()
        {
            data podatki = Helper.Beri();
            
            return View(podatki);
        }
    }
}