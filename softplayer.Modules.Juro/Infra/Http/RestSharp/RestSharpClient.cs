using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Juro.Infra.Http.RestSharp
{
    public class RestSharpClient
    {
        private string _baseUrl;

        public RestSharpClient(string baseUrl)
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
