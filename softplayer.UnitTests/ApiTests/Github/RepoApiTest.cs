using FluentAssertions;
using RestSharp;
using softplayer.Modules.Code.DTOs;
using softplayer.Modules.Code.Infra.Services;
using softplayer.Modules.Code.Infra.Services.Repo;
using softplayer.Modules.Code.Services;
using System;
using Xunit;

namespace softplayer.Tests.ApiTests
{
    public class RepoApiTest
    {
        [Fact(DisplayName = "it should be able to return an url")]
        public async void Filled_url_field()
        {
            RestClient client = new RestClient("https://api.github.com");
            RestRequest request = new RestRequest("repos/gablemos/softplayer", Method.GET);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.ExecuteAsync<RepoDTO>(request);
            var expected = new RepoDTO
            {
                html_url = "https://github.com/gablemos/softplayer",
                description = "-- Softplan Test --",
                git_url = "git://github.com/gablemos/softplayer.git"
            };

            response.StatusCode.Should().Be(200);
            expected.html_url.Should().Be(response.Data.html_url);
            expected.Should().BeEquivalentTo(response.Data);
        }
    }
}
