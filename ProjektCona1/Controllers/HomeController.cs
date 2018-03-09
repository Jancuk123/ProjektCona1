using ProjektCona1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektCona1.Controllers
{
    public class HomeController : Controller
    {
        private pc1Context db1 = new pc1Context();
        public ActionResult Index()
        {
            data podatki = Helper.Beri();

            //16.01.2018 15:30 CET
            //01234567890123456789
            //16.01.2018 9:30 CET
            if (podatki != null)
            {
                string zadnjiDatum = podatki.metData.valid;
                if (zadnjiDatum.Length == 20)
                {
                    int dan = int.Parse(zadnjiDatum.Substring(0, 2));
                    int mesec = int.Parse(zadnjiDatum.Substring(3, 2));
                    int leto = int.Parse(zadnjiDatum.Substring(6, 4));
                    int ura = int.Parse(zadnjiDatum.Substring(11, 2));
                    int minuta = int.Parse(zadnjiDatum.Substring(14, 2));
                    DateTime datum = new DateTime(leto, mesec, dan, ura, minuta, 0);
                    ViewData["datum"] = datum;
                    if (datum.Hour > 20 | datum.Hour < 5)
                        ViewData["delDan"] = "night";
                    else
                        ViewData["deldan"] = "day";
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
                    if (datum.Hour > 20 | datum.Hour < 5)
                        ViewData["delDan"] = "night";
                    else
                        ViewData["deldan"] = "day";
                }

                ViewData["temp"] = podatki.metData.t;
                ViewData["smer"] = podatki.metData.dd_icon;
                ViewData["vlaga"] = podatki.metData.rh;
                ViewData["oblacnost"] = podatki.metData.nn_icon;
                ViewData["pojavi"] = podatki.metData.wwsyn_icon;
            }
            else
            {
                DateTime datum = DateTime.Now;
                ViewData["datum"] = datum;
                if (datum.Hour > 20 | datum.Hour < 5)
                    ViewData["delDan"] = "night";
                else
                    ViewData["deldan"] = "day";
                ViewData["temp"] = "?";
                ViewData["smer"] = "?";
                ViewData["vlaga"] = "?";
                ViewData["oblacnost"] = "";
                ViewData["pojavi"] = "";
            }

            var data = from element in db1.Podatkis
                       group element by element.IdPostaje
                       into groups
                       select groups.OrderByDescending(p => p.Id).FirstOrDefault();
            return View(data);
        }

        public ActionResult Indexeng()
        {
            var data = from element in db1.Podatkis
                       group element by element.IdPostaje
                  into groups
                       select groups.OrderByDescending(p => p.Cas).FirstOrDefault();
            return View(data);
        }

        public ActionResult Indexita()
        {
            var data = from element in db1.Podatkis
                       group element by element.IdPostaje
                  into groups
                       select groups.OrderByDescending(p => p.Cas).FirstOrDefault();
            return View(data);
        }
    }
}