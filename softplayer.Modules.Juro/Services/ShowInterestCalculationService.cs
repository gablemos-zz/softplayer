using softplayer.Modules.Juro.Infra.Services;
using softplayer.Modules.Juro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Juro.Services
{
    public class ShowInterestCalculationService
    {
        public async Task<InterestRateDTO> Execute(double valorinicial, int meses)
        {
            InterestRateServiceAPI serviceAPI = new InterestRateServiceAPI();

            var juros = await serviceAPI.Get();

            var calc = valorinicial * Math.Pow((1 + juros), meses);

            return new InterestRateDTO { value = Math.Round(calc,3) };
        }
    }
}
