using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWeather;

namespace NUnit.BasicWeatherTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test_AggregateWeatherData_With_No_Records_Passed_In()
        {
            WeatherData[] wd = new WeatherData[0];
            WeatherService ws = new WeatherService();
            IEnumerable<CityAveragedWeatherData> cawd = ws.AggregateWeatherData(wd, new DateTime(2017, 10, 1), new DateTime(2017, 10, 31));
        }

        public WeatherData[] GetWeatherData_1_Record_ForTest()
        { 
            var wd = new WeatherData[1].Select(w => new WeatherData()).ToArray();
            wd[0].City = "Denver";
            wd[0].State = "CO";
            wd[0].Date = new DateTime(2017, 10, 1);
            wd[0].HighTemp = 76;
            wd[0].LowTemp = 45;
            return wd;
        }

        [Test]
        public void Test_AggregateWeatherData_With_1_Records_Passed_In()
        {
            BasicWeatherDataManger bwdm = new BasicWeatherDataManger();
            WeatherData[] wd = GetWeatherData_1_Record_ForTest();
            WeatherService ws = new WeatherService();
            IEnumerable<CityAveragedWeatherData> cawd = ws.AggregateWeatherData(wd, new DateTime(2017, 10, 1), new DateTime(2017, 10, 1));
            Assert.AreEqual(cawd.First().AverageHighTemp, 76);
            Assert.AreEqual(cawd.First().AverageLowTemp, 45);
        }

        public WeatherData[] GetWeatherData_5_City_Records_ForTestOfAverage()
        {
            var wd = new WeatherData[5].Select(w => new WeatherData()).ToArray();

            wd[0].City = "Denver";
            wd[0].State = "CO";
            wd[0].Date = new DateTime(2017, 10, 1);
            wd[0].HighTemp = 76;
            wd[0].LowTemp = 45;

            wd[1].City = "Denver";
            wd[1].State = "CO";
            wd[1].Date = new DateTime(2017, 10, 2);
            wd[1].HighTemp = 80;
            wd[1].LowTemp = 48;

            wd[2].City = "Denver";
            wd[2].State = "CO";
            wd[2].Date = new DateTime(2017, 10, 3);
            wd[2].HighTemp = 59;
            wd[2].LowTemp = 36;

            wd[3].City = "Denver";
            wd[3].State = "CO";
            wd[3].Date = new DateTime(2017, 10, 4);
            wd[3].HighTemp = 70;
            wd[3].LowTemp = 40;

            wd[4].City = "Denver";
            wd[4].State = "CO";
            wd[4].Date = new DateTime(2017, 10, 5);
            wd[4].HighTemp = 79;
            wd[4].LowTemp = 47;

            return wd;

        }

        [Test]
        public void Test_AggregateWeatherData_With_5_Same_City_Records_Passed_In()
        {
            BasicWeatherDataManger bwdm = new BasicWeatherDataManger();
            WeatherData[] wd = GetWeatherData_5_City_Records_ForTestOfAverage();
            WeatherService ws = new WeatherService();
            IEnumerable<CityAveragedWeatherData> cawd = ws.AggregateWeatherData(wd, new DateTime(2017, 10, 1), new DateTime(2017, 10, 31));             
            Assert.AreEqual(cawd.First().AverageHighTemp, 72.8);
            Assert.AreEqual(cawd.First().AverageLowTemp, 43.2);
            }
        }
    }
}
