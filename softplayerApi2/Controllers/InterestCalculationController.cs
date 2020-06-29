using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using softplayer.Modules.Juro.Infra.Services;
using softplayer.Modules.Juro.Models;
using softplayer.Modules.Juro.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace softplayerApi2.Controllers
{
    [Route("api/v1/calculajuros")]
    [ApiController]
    public class InterestCalculationController : ControllerBase
    {

        [HttpGet()]
        public async Task<ActionResult> Get(double valorinicial, int meses)
        {
            //adicionar injeção de dependencia
            InterestRateAPIService interestRateServiceApi = new InterestRateAPIService();
            ShowInterestCalculationService InterestCalculationService = new ShowInterestCalculationService(interestRateServiceApi);
            InterestRateDTO interestRate = await InterestCalculationService.Execute(valorinicial, meses);

            return Ok(interestRate);
        }
    }
}
