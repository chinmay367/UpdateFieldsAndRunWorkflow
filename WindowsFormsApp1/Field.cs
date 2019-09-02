﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Field
    {
        public List<string> getFields(string resource, string accessToken, string entity, string record)
        {
            using (var client = new HttpClient())

            {
                string uriStr = resource + "/api/data/v9.0/" + entity + "(" + record + ")/";
                Uri uri = new Uri(uriStr);
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Authorization =
                  new AuthenticationHeaderValue("Bearer", accessToken);
                client.Timeout = new TimeSpan(0, 2, 0);

                client.DefaultRequestHeaders.Add("Accept", "application/json");
                List<string> mylist = new List<string>();

                HttpResponseMessage response = client.GetAsync("").GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    var products = response.Content.ReadAsStringAsync().Result;
                    string s = products.ToString();
                    //Console.WriteLine("s= " + s);
                    JObject results = JObject.Parse(s);
                    //Console.WriteLine(results);

                    foreach (var result in results)

                    { 
                        mylist.Add(result.Key);
                    }
                }
                return mylist;

            }
        }
    }
}
