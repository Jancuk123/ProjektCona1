using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjektCona1.Models;

namespace ProjektCona1.Controllers
{
    public class PodatkiController : Controller
    {
        private pc1Context db = new pc1Context();

        // GET: Podatki
        public ActionResult Index()
        {
            var data = (from x in db.Podatkis
                        orderby x.Id descending
                        select x).Take(108);

            var tpovp = from t in data
                        group t by new
                        {
                            t.Cas
                        } into g
                        select new
                        {
                            PovpTemp = g.Average(p => p.Temp),
                            g.Key.Cas
                        };

            var vlpovp = from t in data
                        group t by new
                        {
                            t.Cas
                        } into g
                        select new
                        {
                            PovpVlg = g.Average(p => p.Vlaga),
                            g.Key.Cas
                        };

            ViewData["TempAvg"] = tpovp;
            ViewData["VlagaAvg"] = vlpovp;

            return View(data);
        }

        public ActionResult Postaja(int? id)
        {
            int stevilka = id ?? 1;
            var data = (from x in db.Podatkis
                        where x.IdPostaje==stevilka
                        orderby x.Id descending
                        select x).Take(50);

            var tpovp = from t in data
                        group t by new
                        {
                            t.Cas
                        } into g
                        select new
                        {
                            PovpTemp = g.Average(p => p.Temp),
                            g.Key.Cas
                        };

            var vlpovp = from t in data
                         group t by new
                         {
                             t.Cas
                         } into g
                         select new
                         {
                             PovpVlg = g.Average(p => p.Vlaga),
                             g.Key.Cas
                         };

            var tzagraf = (from x in tpovp
                           select x).Take(10);
            var vlzagraf = (from x in vlpovp
                            select x).Take(10);
            ViewData["TempAvg"] = tzagraf;
            ViewData["VlagaAvg"] = vlzagraf;
            ViewData["id"] = stevilka;

            return View(data);
        }

    }
}
