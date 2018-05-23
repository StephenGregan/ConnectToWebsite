using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ConsoleAppLogin.Json;

namespace ConsoleAppLogin
{
    class Program
    {

        static void Main()
        {
            var shows = LoginAndDeserializeJson();
            Console.WriteLine(shows);

        }

        static string LoginAndDeserializeJson()
        {

            using (var client = new WebClientEx())
            {
                var values = new NameValueCollection
            {
                { "j_username", "[PASSWORD]" },
                { "j_password", "[USERNAME]" },
            };
                // Authenticate
                client.UploadValues("https://tie.interpreterintelligence.com/j_spring_security_check", values);
                Console.WriteLine("Successfully logged in to ii.....");
                Console.WriteLine();
                // Download desired page
                var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/visit");

                //Not Working...
                //var token = JToken.Parse(json);

                //if (token.Type == JTokenType.Object)
                //    token = new JArray(token);

                //var a = token.ToObject<DataTable>();

                var results = JsonConvert.DeserializeObject<Json>(json);
                Console.WriteLine("Deserialized Json : " + json);

                return json;
            }
        }

        /// <summary>
        /// A custom WebClient featuring a cookie container
        /// </summary>

        public class WebClientEx : WebClient
        {
            public CookieContainer CookieContainer { get; private set; }

            public WebClientEx()
            {
                CookieContainer = new CookieContainer();
            }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var request = base.GetWebRequest(address);
                if (request is HttpWebRequest)
                {
                    (request as HttpWebRequest).CookieContainer = CookieContainer;
                }
                return request;
            }
        }
    }
}









