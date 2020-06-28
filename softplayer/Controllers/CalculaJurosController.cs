using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace softplayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet()]
        public string Get(int valorinicial, int tempo)
        {
            
            RestClient client = new RestClient("http://localhost:44340/api/taxajuros");
            RestRequest request = new RestRequest(Method.GET);
            //request.AddHeader("Content-Type", "application/json");
            var response = client.Execute(request);

            //var client = new RestClient("http://viacep.com.br/ws/012241040/json/");
            //var client = new RestClient("http://localhost:44340/api/taxajuros");
            //var RSrequest = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };

            //var response = client.Execute(RSrequest);

            //var x = valorinicial * (1 + juros.Data) ^ tempo;
            return "Resultado:";
        }
    }
}
