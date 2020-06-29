using FluentAssertions;
using softplayer.Modules.Code.Infra.Services;
using softplayer.Modules.Code.Infra.Services.Repo;
using softplayer.Modules.Code.Services;
using softplayer.Modules.Juro.Infra.Services;
using softplayer.Modules.Juro.Infra.Services.InterestRate;
using softplayer.Modules.Juro.Services;
using System;
using Xunit;

namespace softplayer.Tests.UnitTests
{
    public class ShowInterestCalculationServiceTest
    {
        private readonly FakeInterestRateAPIService fakeInterestRateAPIService = new FakeInterestRateAPIService();

        [Fact(DisplayName = "it should be able to make the calc")]
        public async void Make_the_calc()
        {
            ShowInterestCalculationService interestCalculationService = new ShowInterestCalculationService(fakeInterestRateAPIService);

            var result = await interestCalculationService.Execute(100, 5);
            var expected = 105.10;

            expected.Should().Be(result.value);
        }
    }
}
