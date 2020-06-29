using FluentAssertions;
using RestSharp;
using softplayer.Infra.Http.RestSharp;
using softplayer.Modules.Code.Infra.Services;
using softplayer.Modules.Code.Infra.Services.Repo;
using softplayer.Modules.Code.Services;
using softplayer.Modules.Juro.Models;
using System;
using Xunit;

namespace softplayer.Tests.ApiTests
{
    public class InterestRateApiTest
    {        
        [Fact(DisplayName = "Interest Rate should be 1 % or 0.01")]
        public async void Filled_url_field()
        {
            RestClient client = new RestClient("https://softplayer.azurewebsites.net/");
            RestRequest request = new RestRequest("api/v1/taxajuros", Method.GET);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.ExecuteAsync<InterestRateDTO>(request);
            var expected = new InterestRateDTO { value = 0.01 };

            response.StatusCode.Should().Be(200);
            expected.value.Should().Be(response.Data.value);
            expected.Should().BeEquivalentTo(response.Data);
        }
    }
}
