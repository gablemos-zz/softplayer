using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace softplayerApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        // GET: api/<CalculaJurosController>
        [HttpGet()]
        public async Task<string> Get(int valorinicial, int meses)
        {

            RestClient client = new RestClient("https://localhost:5001/api/taxajuros");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.ExecuteAsync<double>(request);
            var juros = response.Data;            

            var x = valorinicial * Math.Pow((1 + juros), meses);
            return string.Format("{0:0.00}", x);
        }
    }
}
