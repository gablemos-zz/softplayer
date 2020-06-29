using softplayer.Modules.Code.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Code.Infra.Services.Repo
{
    public class FakeRepoAPIService : IRepoAPIService
    {
        public async Task<RepoDTO> Get()
        {
            await Task.Delay(1);
            return new RepoDTO 
            {
                description = "description",
                git_url = "git",
                html_url = "https://github.com/gablemos/softplayer"
            };
        }
    }
}
