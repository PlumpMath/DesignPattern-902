using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurement(80, 65, 30.4f);
            weatherData.setMeasurement(82, 70, 29.2f);
            currentDisplay.RemoveObserver();
            weatherData.setMeasurement(78, 90, 29.2f);

            Console.ReadLine();
        }
    }
}
