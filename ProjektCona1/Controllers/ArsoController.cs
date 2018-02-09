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

            //var ostalo = (from x in podatki.metData
            //              select new { x.dd_icon, x.tavg, x.rhavg }).ToList();
            //var datumiString = (from x in podatki.metData
            //                    select x.valid).ToList();
            //List<DateTime> datumi = new List<DateTime>();

            //foreach (var d in datumiString)
            //{                                                //<valid>16.01.2018 15:30 CET</valid>
            //    if (d.Length == 20)                          //       01234567890123456789  
            //    {
            //        int dan = int.Parse(d.Substring(0, 2));
            //        int mesec = int.Parse(d.Substring(3, 2));
            //        int leto = int.Parse(d.Substring(6, 4));
            //        int ura = int.Parse(d.Substring(11, 2));
            //        int minuta = int.Parse(d.Substring(14, 2));

            //        DateTime datum = new DateTime(leto, mesec, dan, ura, minuta, 0);
            //        datumi.Add(datum);
            //    }
            //    else
            //    {
            //        int dan = int.Parse(d.Substring(0, 2));
            //        int mesec = int.Parse(d.Substring(3, 2));
            //        int leto = int.Parse(d.Substring(6, 4));
            //        int ura = int.Parse(d.Substring(11, 1));
            //        int minuta = int.Parse(d.Substring(13, 2));

            //        DateTime datum = new DateTime(leto, mesec, dan, ura, minuta, 0);
            //        datumi.Add(datum);
            //    }
            //}

            //var rezultati = (from x in ostalo
            //                 from y in datumi
            //                 orderby y
            //                 select new { cas = y, smer = x.dd_icon, vlaga = x.rhavg, temp = x.tavg }).ToList();

            return View(podatki);
            
        }
    }
}