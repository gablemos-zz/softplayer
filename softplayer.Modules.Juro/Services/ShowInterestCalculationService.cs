using softplayer.Modules.Juro.Infra.Services;
using softplayer.Modules.Juro.Infra.Services.InterestRate;
using softplayer.Modules.Juro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Juro.Services
{
    public class ShowInterestCalculationService
    {
        private readonly IInterestRateAPIService _serviceApi;

        public ShowInterestCalculationService(IInterestRateAPIService serviceApi)
        {
            _serviceApi = serviceApi;
        }
        public async Task<InterestRateDTO> Execute(double valorinicial, int meses)
        {
            var juros = await _serviceApi.Get();

            var calc = valorinicial * Math.Pow((1 + juros), meses);

            return new InterestRateDTO { value = Math.Round(calc,2) };
        }
    }
}
