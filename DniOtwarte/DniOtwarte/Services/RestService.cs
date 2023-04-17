
using Newtonsoft.Json;
using DniOtwarte.Models;
using DniOtwarte.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DniOtwarte.Services
{
    public class RestService : IRestService
    {
        private HttpClient client;
        public RestService()
        { 
            client = new HttpClient();
        }
        public async Task<Rootobject> GetDataAsync()
        {
            var responseModel = new Rootobject();
            Uri uri = new Uri($"{Constants.RestUrl}");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    responseModel = JsonConvert.DeserializeObject<Rootobject>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return responseModel;
        }
    }
}

