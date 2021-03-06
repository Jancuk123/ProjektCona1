﻿using ProjektCona1.Models;
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
            string stopnja = BralnikXML.Alarm();
            //16.01.2018 15:30 CEST
            //16.01.2018 1:30 CEST
            //0123456789012345678901   !!!
            //16.01.2018 19:30 CET
            //16.01.2018 9:30 CET
            if (podatki != null)
            {
                string zadnjiDatum = podatki.Datum;
                if (podatki.Datum.Contains("CEST"))
                {
                    //16.01.2018 15:30 CEST
                    //16.01.2018 1:30 CEST
                    //0123456789012345678901   !!!
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
                }
                else
                {
                    //0123456789012345678901   !!!
                    //16.01.2018 19:30 CET
                    //16.01.2018 9:30 CET
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
                }

                ViewData["temp"] = podatki.Temperatura;
                ViewData["smer"] = podatki.SmerV;
                ViewData["vlaga"] = podatki.Vlaga;
                ViewData["moc"] = podatki.MocV;
                ViewData["hitrost"] = podatki.HitrostV;
            
                if (podatki.Oblacnost == "")
                    ViewData["oblacnost"] = "unknown";
                else
                    ViewData["oblacnost"] = podatki.Oblacnost;

                ViewData["pojavi"] = podatki.Pojavi;

            }  //vreme
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
                ViewData["moc"] = "?";
                ViewData["hitrost"] = "?";
                ViewData["oblacnost"] = "";
                ViewData["pojavi"] = "";
            }
            if (stopnja != null)
            {
                if (stopnja.Contains("1/4") == true)
                    ViewData["stopnja"] = "prvastopnja";
                else
                     if (stopnja.Contains("2/4") == true)
                    ViewData["stopnja"] = "drugastopnja";
                else
                         if (stopnja.Contains("3/4") == true)
                    ViewData["stopnja"] = "tretjastopnja";
                else
                             if (stopnja.Contains("4/4") == true)
                    ViewData["stopnja"] = "cetrtastopnja";
                else
                    ViewData["stopnja"] = "nistopnje";
            }    //alarm
            else
                ViewData["stopnja"] = "nistopnje";

            var data = from element in db1.Podatkis
                       group element by element.IdPostaje
                       into groups
                       orderby groups.Key
                       select groups.OrderByDescending(p => p.Id).FirstOrDefault();
            return View(data);
        }

        public ActionResult _indexPostaje()
        {
            var data = from element in db1.Podatkis
                       group element by element.IdPostaje
                       into groups
                       orderby groups.Key
                       select groups.OrderByDescending(p => p.Id).FirstOrDefault();
            return View("_postaje",data);
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