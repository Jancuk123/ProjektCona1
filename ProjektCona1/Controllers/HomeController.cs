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
            Vreme podatki = BralnikXML.Branje();

            //16.01.2018 15:30 CEST
            //012345678901234567890
            //16.01.2018 9:30 CET
            if (podatki != null)
            {
                string zadnjiDatum = podatki.Datum;
                if (zadnjiDatum.Length == 21)
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

                ViewData["temp"] = podatki.Temperatura;
                ViewData["smer"] = podatki.SmerV;
                ViewData["vlaga"] = podatki.Vlaga;

                if (podatki.Oblacnost == "")
                    ViewData["oblacnost"] = "unknown";
                else
                ViewData["oblacnost"] = podatki.Oblacnost;
                
                ViewData["pojavi"] = podatki.Pojavi;
                
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
                       orderby groups.Key
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