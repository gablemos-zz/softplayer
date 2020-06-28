using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace softplayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        // GET: api/<CalculaJurosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1CalculaJurosController", "value2CalculaJurosController" };
        }

        // GET api/<CalculaJurosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "valueCalculaJurosController";
        }

        // POST api/<CalculaJurosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CalculaJurosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CalculaJurosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
