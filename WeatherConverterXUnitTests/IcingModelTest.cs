using BinarWeatherConverter.Models;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherConverterXUnitTests
{
    public class IcingModelTest
    {
        public IcingModel? icingModel;

        [Fact]
        public void Test_SeverityEquals4()
        {
            icingModel = new IcingModel("640409");

            Assert.Equal(4, icingModel.Severity);
        }

        [Fact]
        public void Test_GetIntensityEqualsModSevere()
        {
            icingModel = new IcingModel("640409");

            Assert.Equal("Mod/Severe\nIcing", icingModel.GetIntensity);
        }

        [Fact]
        public void Test_HeightOfIcingEquals040()
        {
            icingModel = new IcingModel("640409");

            Assert.Equal(040, icingModel.HeightOfIcing);
        }

        [Fact]
        public void Test_ThicknessEquals9()
        {
            icingModel = new IcingModel("640409");

            Assert.Equal(9, icingModel.Thickness);
        }
    }
}
