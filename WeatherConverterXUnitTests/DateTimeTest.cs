using BinarWeatherConverter.Models;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherConverterXUnitTests
{
    public class DateTimeTest
    {
        public DateTimeModel? dateTimeModel;

        [Fact]
        public void Test_DateTimeModelWithHour24_ValidMidnight()
        {
            dateTimeModel = new DateTimeModel("0224/0224");

            Assert.Equal("16", Convert.ToString(dateTimeModel.StartTime.Hour));
        }

        [Fact]
        public void Test_StartTimeEquals18()
        {
            dateTimeModel = new DateTimeModel("0202/0203");

            Assert.Equal("18", Convert.ToString(dateTimeModel.StartTime.Hour));
        }


        [Fact]
        public void Test_EndTimeEquals19()
        {
            dateTimeModel = new DateTimeModel("0202/0203");

            Assert.Equal("19", Convert.ToString(dateTimeModel.EndTime.Hour));
        }

        [Fact]
        public void Test_ForeCaseDateEqualsWed01Feb()
        {
            dateTimeModel = new DateTimeModel("Wed, 01 Feb", true);

            Assert.Equal("Wed, 01 Feb", Convert.ToString(dateTimeModel.ForecastDate.ToString("ddd, dd MMM")));

        }

    }
}
