using softplayer.Modules.Juro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Juro.Services
{
    class ShowInterestRateService
    {
        public InterestRate Execute()
        {
            return new InterestRate { value = 0.01 };
        }
    }
}
