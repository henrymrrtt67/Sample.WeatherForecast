using System;
using Xunit;
using Samples.WeatherForecast.Api.Controllers;
using Microsoft.Extensions.Logging.Abstractions;

namespace Samples.WeatherForecast.Api.UnitTest
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void GIVEN_software_is_running_WHEN_WeatherForecast_endpoint_is_called_THEN_controller_should_return_a_list_of_values()
        {
            var logger = new NullLogger<WeatherForecastController>();
            var service = new WeatherForecastController(logger);

            var result = service.Get();

            Assert.NotNull(result);
        }
    }
}
