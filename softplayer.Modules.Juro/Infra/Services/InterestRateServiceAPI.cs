using softplayer.Infra.Http.RestSharp;
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
            InfraRestSharpClient client = new InfraRestSharpClient("https://localhost:5001");
            var response = await client.Get<InterestRateDTO>("api/taxajuros");
            return response.value;
        }
    }
}
