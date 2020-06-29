using softplayer.Modules.Code.Infra.Services;
using softplayer.Modules.Code.Infra.Services.Repo;
using softplayer.Modules.Code.Services;
using System;
using Xunit;

namespace softplayer.UnitTests
{
    public class ShowRepoServiceTest
    {
        private readonly FakeRepoAPIService fakeRepoServiceApi = new FakeRepoAPIService();

        [Fact(DisplayName = "it should be able to return an url")]
        public async void Filled_url_field()
        {
            ShowRepoService repoService = new ShowRepoService(fakeRepoServiceApi);

            var expected = "https://github.com/gablemos/softplayer";
            var result = await repoService.Execute();

            Assert.Equal(expected, result.html_url);
        }
    }
}
