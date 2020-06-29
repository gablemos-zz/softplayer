using softplayer.Infra.Http.RestSharp;
using softplayer.Modules.Juro.Infra.Services.InterestRate;
using softplayer.Modules.Juro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Juro.Infra.Services
{
    public class InterestRateAPIService : IInterestRateAPIService
    {
        public async Task<double> Get()
        {
            InfraRestSharpClient client = new InfraRestSharpClient("https://localhost:44340");
            var response = await client.Get<InterestRateDTO>("api/v1/taxajuros");
            return response.value;
        }
    }
}
