using Brookfield.Models;
using Brookfield.Shared;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Brookfield.Services
{
    public class DynamicAPIService : IDynamicAPIService
    {
        private readonly HttpClient httpClient;
       
        public DynamicAPIService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetAppConfiguration(string connection, string spName, string CommondName)
        {
            string response=await httpClient.GetStringAsync("api/Values/Get/" + connection + "," + spName + "," + CommondName);
            return response;          
        }

        public async Task<string> InsertData(ExpandoObject exObj, string connection, string spName, string CommondName)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var content = new StringContent(JsonConvert.SerializeObject(exObj), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("api/Values/Post/" + CommondName + "," + connection + "," + spName , content).Result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> GetDatabyParam(List<Param> exObj, string connection, string spName, string CommondName)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var content = new StringContent(JsonConvert.SerializeObject(exObj), Encoding.UTF8, "application/json");
            var response= await httpClient.PostAsync("api/Values/GetDatabyParam/" + connection + "," + spName , content).Result.Content.ReadAsStringAsync();
            return response;
        }
    }
}
