using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace WeatherConverterXUnitTests
{
    public class TemperatureModelTest
    {
        public TemperatureModel? temperatureModel;
        //Example: TX27/0515L TN02/0506L

        [Fact]
        public void Test_MaxTempEqual27()
        {
            temperatureModel = new TemperatureModel("TX27/0515L");

            Assert.Equal(27, temperatureModel.MaxTemp);
        }

        [Fact]
        public void Test_MinTempEqual02()
        {
            temperatureModel = new TemperatureModel("TN02/0506L");

            Assert.Equal(02, temperatureModel.MinTemp);
        }

        [Fact]
        public void Test_MaxTempDateTimeEquals0515()
        {
            temperatureModel = new TemperatureModel("TX27/0515L");

            Assert.Equal("0515", temperatureModel.MaxTempDateTime.ToString("ddHH"));
        }

        [Fact]
        public void Test_MinTempDateTimeEquals0506()
        {
            temperatureModel = new TemperatureModel("TN02/0506L");

            Assert.Equal("0506", temperatureModel.MinTempDateTime.ToString("ddHH"));
        }

        [Fact]
        public void Test_ForecaseMaxTempMatches()
        {
            temperatureModel = new("57Â°F / 14Â°C", true);

            Assert.Equal("57Â°F / 14Â°C", temperatureModel.ForecastMaxTemp);
        }

        [Fact]
        public void Test_ForecaseMinTempMatches()
        {
            temperatureModel = new("23Â°F / M05Â°C", false);

            Assert.Equal("23Â°F / M05Â°C", temperatureModel.ForecastMinTemp);
        }
    }
}
