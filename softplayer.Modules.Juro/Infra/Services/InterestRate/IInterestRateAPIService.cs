using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Juro.Infra.Services.InterestRate
{
    public interface IInterestRateAPIService
    {
        Task<double> Get();
    }
}
