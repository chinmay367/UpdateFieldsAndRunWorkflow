using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Token
    {
        public string getToken()
        {
            var token = GetTokenWithoutADAL().GetAwaiter().GetResult();
            return token.ToString();
        }

        static async Task<string> GetTokenWithoutADAL()
        {
            try
            {
                string azureAdDomain = "your azure domain guid";
                string loginUrl = $"https://login.microsoftonline.com/{azureAdDomain}/oauth2/token";

                string clientId = "your client id of azure app";
                string clientSecret = "client secret of client id";
                string resource = "resource to which you want to make connection";
                //https://sourcing.crm.dynamics.com



                HttpClient client = new HttpClient();
                var postData = $"client_id={clientId}&client_secret={clientSecret}&resource={resource}&grant_type=client_credentials";

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, loginUrl);
                request.Content = new StringContent(postData, System.Text.Encoding.UTF8);
                request.Content.Headers.Remove("Content-Type");
                request.Content.Headers.TryAddWithoutValidation("Content-Type", $"application/x-www-form-urlencoded");

                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                var responseMessage = client.SendAsync(request).GetAwaiter().GetResult();
                var jsonResponseString = await responseMessage.Content.ReadAsStringAsync();

                var jsonContent = JsonConvert.DeserializeObject<System.Collections.Generic.Dictionary<string, string>>(jsonResponseString);
                Console.WriteLine(jsonContent["access_token"]);
                var accessToken = jsonContent["access_token"];
                System.Diagnostics.Debug.WriteLine(jsonContent["access_token"]);

                return jsonContent["access_token"];
            }
            catch
            {
                return string.Empty;
            }

        }

    }
}
