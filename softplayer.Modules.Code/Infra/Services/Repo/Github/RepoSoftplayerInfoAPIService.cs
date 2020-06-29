using softplayer.Infra.Http.RestSharp;
using softplayer.Modules.Code.DTOs;
using System.Threading.Tasks;

namespace softplayer.Modules.Code.Infra.Services
{
    public class RepoSoftplayerInfoAPIService : IRepoAPIService
    {
        public async Task<RepoDTO> Get()
        {
            InfraRestSharpClient client = new InfraRestSharpClient("https://api.github.com");
            var response = await client.Get<RepoDTO>("repos/gablemos/softplayer");
            return response;
        }
    }
}
