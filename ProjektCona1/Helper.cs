using ProjektCona1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Xml.Serialization;

namespace ProjektCona1
{
    public class Helper
    {
        public static data Beri()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
               new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));

            HttpResponseMessage response = client.GetAsync(new Uri("http://www.meteo.si/uploads/probase/www/observ/surface/text/sl/recent/observationAms_NOVA-GOR_history.xml")).Result;
            if (response.IsSuccessStatusCode)
            {

                var x = response.Content.ReadAsStreamAsync().Result;
                XmlSerializer ser = new XmlSerializer(typeof(data));
                Stream rawXml = x;
                var p = ser.Deserialize(rawXml) as data;
                
                return p;
            }
            else
            { return null; }
        }
    }
}