using DAL.Model;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Web.Script.Serialization;

namespace DAL
{
    public class Repository
    {
        public static Representations GetRepresentations(string url)
        {
            string data = getJSON(url);
            data = data.Insert(0, @"{""representations"":");
            data += "}";
            Representations representations = new JavaScriptSerializer().Deserialize<Representations>(data);
            return representations;
        }

        public static string GetStartingEleven(string url)
        {
            string rawData = getJSON(url);
            rawData = rawData.Insert(0, @"{""info"": {""details"":");
            rawData += "}}";
            Debug.WriteLine(rawData);
            var data = JObject.Parse(rawData);
            string testString = (string)data["info"]["details"]["venue"];
            return testString;
        }

        private static string getJSON(string url)
        {
            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }
            return json;
        }
    }
}
