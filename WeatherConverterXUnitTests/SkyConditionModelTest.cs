using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherConverterXUnitTests
{
    public class SkyConditionModelTest
    {
        public SkyConditionModel? skyConditionModel;
        //Samples containt: SKC, FEW, SCT, BKN, OVC: BKN250 FEW040 SCT120 OVC090 SKC

        [Fact]
        public void Test_ConditionEqualsSKC()
        {
            skyConditionModel = new SkyConditionModel("SKC");

            Assert.Equal("SKC", skyConditionModel.Condition);
        }

        [Fact]
        public void Test_ConditionEqualsBKN()
        {
            skyConditionModel = new SkyConditionModel("BKN250");

            Assert.Equal("BKN", skyConditionModel.Condition);
        }

        [Fact]
        public void Test_BaseHeightEquals25()
        {
            skyConditionModel = new SkyConditionModel("BKN250");

            Assert.Equal(25, skyConditionModel.BaseHeight);
        }

        [Fact]
        public void Test_AvationDisplayEqualsBKN_25K_ft()
        {
            skyConditionModel = new SkyConditionModel("BKN250");

            Assert.Equal("BKN 25k ft", skyConditionModel.AvationDisplay);
        }

        [Fact]
        public void Test_ForecastDisplayEqualsClear()
        {
            skyConditionModel = new SkyConditionModel("Clear", true);

            Assert.Equal("Clear", skyConditionModel.ForecastDisplay);
        }
    }
}
