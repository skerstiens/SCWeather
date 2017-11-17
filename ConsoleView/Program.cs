using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWeather;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicWeatherDataManger bwdm = new BasicWeatherDataManger();
            WeatherData[] wd = bwdm.GetWeatherData();
            WeatherService ws = new WeatherService();
            Console.WriteLine("October Temps");
            IEnumerable<CityAveragedWeatherData> cawd = ws.AggregateWeatherData(wd, new DateTime(2017,10,1), new DateTime(2017,10,31));
            foreach (CityAveragedWeatherData cawdrow in cawd) {
                Console.WriteLine(cawdrow.City + "," + cawdrow.State + " - Avg High: " + cawdrow.AverageHighTemp + " Avg Low: " + cawdrow.AverageLowTemp);
            }
            Console.WriteLine("November Temps");
            cawd = ws.AggregateWeatherData(wd, new DateTime(2017, 11, 1), new DateTime(2017, 11, 30));
            foreach (CityAveragedWeatherData cawdrow in cawd)
            {
                Console.WriteLine(cawdrow.City + "," + cawdrow.State + " - Avg High: " + cawdrow.AverageHighTemp + " Avg Low: " + cawdrow.AverageLowTemp);
            }
            Console.ReadKey();
        }
    }
}
