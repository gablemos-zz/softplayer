using softplayer.Modules.Juro.Infra.Http.RestSharp;
using softplayer.Modules.Juro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Juro.Infra.Services
{
    class InterestRateServiceAPI
    {
        public async Task<double> Get()
        {
            RestSharpClient client = new RestSharpClient("https://localhost:5001");
            var response = await client.Get<InterestRateDTO>("api/taxajuros");
            return response.value;
        }
    }
}
