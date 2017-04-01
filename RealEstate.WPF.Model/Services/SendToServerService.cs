using Newtonsoft.Json;
using RealEstate.WPF.Model.Models;
using RealEstate.WPF.Model.Models.ModelFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Services
{
    public class SendToServerService<TGetClass,TPostClass> where TGetClass : class where TPostClass : class
    {
        public async Task<ResponsePackage<TGetClass>> PostDataByJsonObjectAsync(string pathString, TPostClass SendModel)
        {
            var myContent = JsonConvert.SerializeObject(SendModel);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51608/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsJsonAsync(pathString, SendModel);
            //WebClient
            ResponsePackage<TGetClass> responsePackage = response.Content.ReadAsAsync<ResponsePackage<TGetClass>>().Result;
            return responsePackage;
        }
        public async Task<ResponsePackage<TGetClass>> GetDataByJsonObjectAsync(string pathString)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51608/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(pathString);

            ResponsePackage<TGetClass> responsePackage = response.Content.ReadAsAsync<ResponsePackage<TGetClass>>().Result;
            return responsePackage;
        }
      }
}
