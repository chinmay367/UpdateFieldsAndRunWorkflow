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
    class WorkflwODataWebApi
    {
        private string workflowId;
        private string recordId;
        public WorkflwODataWebApi(string workflowId, string recordId)
        {
            this.workflowId = workflowId;
            this.recordId = recordId;
        }

        public string run_Workflow(string resource, string accessToken)
        {
            using (var client = new HttpClient())
            {
                string uriStr = resource + "/api/data/v9.0/workflows(" + workflowId + ")/Microsoft.Dynamics.CRM.ExecuteWorkflow";
                Uri uri = new Uri(uriStr);
               // Uri uri = new Uri(resource + "/api/data/v9.0/workflows(946333A6-879B-4DBB-8AC9-FC95DBE592EE)/Microsoft.Dynamics.CRM.ExecuteWorkflow");
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Authorization =
                  new AuthenticationHeaderValue("Bearer", accessToken);
                client.Timeout = new TimeSpan(0, 2, 0);
                
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                object data = new
                {
                    EntityId = recordId

                };
                var json = JsonConvert.SerializeObject(data);
               
                StringContent stringContent = new StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                HttpResponseMessage resp = client.PostAsync(uri.ToString(), stringContent).GetAwaiter().GetResult();

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
