using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using softplayer.Modules.Code.DTOs;
using softplayer.Modules.Code.Infra.Services;
using softplayer.Modules.Code.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace softplayerApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowmeTheCodeController : ControllerBase
    {
        [HttpGet()]
        public async Task<ActionResult> Get()
        {
            //TODO
            //Se der tempo adicionar ijeção de dependencia
            RepoSoftplayerInfoAPIService serviceAPI = new RepoSoftplayerInfoAPIService();
            ShowRepoService RepoService = new ShowRepoService(serviceAPI);
            RepoDTO repo = await RepoService.Execute();
            return Ok(repo);
        }
    }
}
