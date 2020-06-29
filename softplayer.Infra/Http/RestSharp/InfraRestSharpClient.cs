using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Infra.Http.RestSharp
{
    public class InfraRestSharpClient
    {
        private string _baseUrl;

        public InfraRestSharpClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        public async Task<T> Get<T>(string resource)
        {
            RestClient client = new RestClient(_baseUrl);
            RestRequest request = new RestRequest(resource, Method.GET);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.ExecuteAsync<T>(request);
            return response.Data;
        }
    }
}
