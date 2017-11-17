using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeather
{
    public class BasicWeatherDataManger
    {
        public WeatherData[] GetWeatherData() { 

            var wd = new WeatherData[14].Select(w => new WeatherData()).ToArray();

            wd[0].City = "Denver";
            wd[0].State = "CO";
            wd[0].Date = new DateTime(2017,10,1);
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

            wd[5].City = "Boulder";
            wd[5].State = "CO";
            wd[5].Date = new DateTime(2017, 10, 1);
            wd[5].HighTemp = 72;
            wd[5].LowTemp = 42;

            wd[6].City = "Boulder";
            wd[6].State = "CO";
            wd[6].Date = new DateTime(2017, 10, 2);
            wd[6].HighTemp = 76;
            wd[6].LowTemp = 41;

            wd[7].City = "Boulder";
            wd[7].State = "CO";
            wd[7].Date = new DateTime(2017, 10, 3);
            wd[7].HighTemp = 60;
            wd[7].LowTemp = 35;

            wd[8].City = "Boulder";
            wd[8].State = "CO";
            wd[8].Date = new DateTime(2017, 10, 4);
            wd[8].HighTemp = 75;
            wd[8].LowTemp = 40;

            wd[9].City = "Boulder";
            wd[9].State = "CO";
            wd[9].Date = new DateTime(2017, 10, 5);
            wd[9].HighTemp = 74;
            wd[9].LowTemp = 44;

            wd[10].City = "Denver";
            wd[10].State = "CO";
            wd[10].Date = new DateTime(2017, 11, 1);
            wd[10].HighTemp = 50;
            wd[10].LowTemp = 32;

            wd[11].City = "Denver";
            wd[11].State = "CO";
            wd[11].Date = new DateTime(2017, 11, 2);
            wd[11].HighTemp = 65;
            wd[11].LowTemp = 39;

            wd[12].City = "Boulder";
            wd[12].State = "CO";
            wd[12].Date = new DateTime(2017, 11, 1);
            wd[12].HighTemp = 51;
            wd[12].LowTemp = 30;

            wd[13].City = "Boulder";
            wd[13].State = "CO";
            wd[13].Date = new DateTime(2017, 11, 2);
            wd[13].HighTemp = 59;
            wd[13].LowTemp = 37;
            return wd;
        }
    }
}
