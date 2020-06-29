using FluentAssertions;
using softplayer.Modules.Code.Infra.Services;
using softplayer.Modules.Code.Infra.Services.Repo;
using softplayer.Modules.Code.Services;
using System;
using Xunit;

namespace softplayer.Tests.IntegrationTests
{
    public class ShowRepoServiceTest
    {
        private readonly RepoSoftplayerInfoAPIService repoServiceApi = new RepoSoftplayerInfoAPIService();

        [Fact(DisplayName = "it should be able to return an url")]
        public async void Filled_url_field()
        {
            ShowRepoService repoService = new ShowRepoService(repoServiceApi);

            var expected = "https://github.com/gablemos/softplayer";
            var result = await repoService.Execute();

            expected.Should().Be(result.html_url);
        }
    }
}
