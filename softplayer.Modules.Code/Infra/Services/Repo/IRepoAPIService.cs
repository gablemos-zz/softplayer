using softplayer.Modules.Code.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace softplayer.Modules.Code.Infra.Services
{
    public interface IRepoAPIService
    {
        Task<RepoDTO> Get();
    }
}
