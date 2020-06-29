using softplayer.Modules.Code.DTOs;
using softplayer.Modules.Code.Infra.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Code.Services
{
    public class ShowRepoService
    {
        private readonly IRepoAPIService _serviceApi;

        public ShowRepoService(IRepoAPIService serviceApi)
        {
            _serviceApi = serviceApi;
        }

        public async Task<RepoDTO> Execute()
        {
            return await _serviceApi.Get();
        }
    }
}
