using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class UpdODataWebApi
    {
        private string entity;
        private string record;
        private string field;
        private string new_Field_Value;

        public UpdODataWebApi(string entity, string record, string field, string new_Field_Value)
        {
            this.entity = entity;
            this.record = record;
            this.field = field;
            this.new_Field_Value = new_Field_Value;
        }
        
        public string update(string resource, string accessToken)
        {
            using (var client = new HttpClient())

            {
                string uriStr = resource + "/api/data/v9.0/" + entity + "(" + record + ")/" + field;
                Uri uri = new Uri(uriStr);
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Authorization =
                  new AuthenticationHeaderValue("Bearer", accessToken);
                client.Timeout = new TimeSpan(0, 2, 0);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                
                Guid g = new Guid("5892ed27-2a18-e911-a989-000d3a314c2b");
                object data;
                if (field == "src_spend")
                {
                    data = new
                    {
                        value = decimal.Parse(new_Field_Value)

                    };
                }
                else if (field == "statuscode" || field == "statecode")
                {
                    data = new
                    {
                        value = Int32.Parse(new_Field_Value)
                    };
                }
                else if (field == "src_issubmitted")
                {
                    data = new
                    {
                        value = Convert.ToBoolean(new_Field_Value)
                    };
                }
                else
                {
                    data = new
                    {
                        value = new_Field_Value

                    };
                }


                //JObject opportClose = new JObject();
                //opportClose["ownerid@odata.bind"] = "/systemusers(3b881624-d00c-e911-a987-000d3a314c2b)";
                //var entity = context.GetEntityFromContext().ToEntity<pwc_contract>();


                var json = JsonConvert.SerializeObject(data);
                Console.WriteLine(json);

                StringContent stringContent = new StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                HttpResponseMessage resp = client.PutAsync(uri.ToString(), stringContent).GetAwaiter().GetResult();

                if (resp.IsSuccessStatusCode)
                {
                    return null;
                }
                else
                {
                    return resp.ToString();
                }

              
            }
        }
    }
}






