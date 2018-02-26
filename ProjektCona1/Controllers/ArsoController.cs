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
                                                               //16.01.2018 15:30 CET
                                                               //01234567890123456789
                                                               //16.01.2018 9:30 CET
            var zadnji = (from x in podatki.metData
                          select new { x.valid, x.tavg, x.dd_icon, x.rhavg }).FirstOrDefault();
            string zadnjiDatum = zadnji.valid;
            if (zadnjiDatum.Length==20)
            {
                int dan = int.Parse(zadnjiDatum.Substring(0, 2));
                int mesec = int.Parse(zadnjiDatum.Substring(3, 2));
                int leto = int.Parse(zadnjiDatum.Substring(6, 4));
                int ura = int.Parse(zadnjiDatum.Substring(11, 2));
                int minuta = int.Parse(zadnjiDatum.Substring(14, 2));
                DateTime datum = new DateTime(leto, mesec, dan, ura, minuta, 0);
                ViewData["datum"] = datum;
            }
            else
            {
                int dan = int.Parse(zadnjiDatum.Substring(0, 2));
                int mesec = int.Parse(zadnjiDatum.Substring(3, 2));
                int leto = int.Parse(zadnjiDatum.Substring(6, 4));
                int ura = int.Parse(zadnjiDatum.Substring(11, 1));
                int minuta = int.Parse(zadnjiDatum.Substring(13, 2));
                DateTime datum = new DateTime(leto, mesec, dan, ura, minuta, 0);
                ViewData["datum"] = datum;
            }

            ViewData["temp"] = zadnji.tavg;
            ViewData["smer"] = zadnji.dd_icon;
            ViewData["vlaga"] = zadnji.rhavg;

            return View(podatki);
            
        }
    }
}