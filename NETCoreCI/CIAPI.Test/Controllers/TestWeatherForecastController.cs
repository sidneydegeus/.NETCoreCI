using CIAPI.Controllers;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CIAPI.Test.Controllers
{
    public class TestWeatherForecastController
    {
        readonly WeatherForecastController weatherForecastController = new WeatherForecastController();

        [Fact]
        public void Get_ShouldReturnForecast_WhenProvidedWithExistingId()
        {
            var expected = new WeatherForecast
            {
                Date = new DateTime(1992, 8, 20),
                TemperatureC = 88,
                Summary = "Bracing"
            };

            var actual = weatherForecastController.Get(1);

            var expectedStr = JsonConvert.SerializeObject(expected);
            var actualStr = JsonConvert.SerializeObject(actual);

            Assert.Equal(expectedStr, actualStr);
        }
    }
}
