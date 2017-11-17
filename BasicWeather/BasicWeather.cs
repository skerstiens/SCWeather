using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeather
{
    //We are compiling a report on the average temperatures among various cities over each month. 
    //We receive individual daily data points from a weather service. 
    //Given a collection of data points over a given month, average the data into the requested format for easier reporting.

    //Please include tests in the testing framework you are most comfortable with.

    //We prefer your completed work in a Git repo.

    public class WeatherService
    {
        public IEnumerable<CityAveragedWeatherData> AggregateWeatherData(WeatherData[] inputData, DateTime startDate, DateTime endDate)
        {            
            var CityAverages =
            from row in inputData
            where startDate <= row.Date && row.Date <= endDate
            orderby row.City, row.State
            group row by new { row.City, row.State} into cityState
            select new CityAveragedWeatherData()
            {
                City = cityState.Key.City,
                State = cityState.Key.State,
                AverageHighTemp = Math.Round(cityState.Average(rec => rec.HighTemp),1),
                AverageLowTemp = Math.Round(cityState.Average(rec => rec.LowTemp),1)
            };
            return CityAverages;
        }
    }

    public class WeatherData
    {
        public string State { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
        public decimal HighTemp { get; set; }
        public decimal LowTemp { get; set; }
    }

    public class CityAveragedWeatherData
    {
        public string State { get; set; }
        public string City { get; set; }
        public decimal AverageHighTemp { get; set; }
        public decimal AverageLowTemp { get; set; }
    }

}
