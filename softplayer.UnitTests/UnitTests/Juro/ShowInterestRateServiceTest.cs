using FluentAssertions;
using softplayer.Modules.Code.Infra.Services;
using softplayer.Modules.Code.Infra.Services.Repo;
using softplayer.Modules.Code.Services;
using softplayer.Modules.Juro.Services;
using System;
using Xunit;

namespace softplayer.Tests.UnitTests
{
    public class ShowInterestRateServiceTest
    {
        [Fact(DisplayName = "Interest Rate should be 1 % or 0.01")]
        public void Interest_Rate_is_1_percent()
        {
            ShowInterestRateService interestRateService = new ShowInterestRateService();

            var result = interestRateService.Execute();
            var expected = 0.01;

            expected.Should().Be(result.value);
        }
    }
}
