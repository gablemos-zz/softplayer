using softplayer.Infra.Http.RestSharp;
using softplayer.Modules.Juro.Infra.Services.InterestRate;
using softplayer.Modules.Juro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Juro.Infra.Services.InterestRate
{
    public class FakeInterestRateAPIService : IInterestRateAPIService
    {
        public async Task<double> Get()
        {
            await Task.Delay(1);
            return 0.01;
        }
    }
}
