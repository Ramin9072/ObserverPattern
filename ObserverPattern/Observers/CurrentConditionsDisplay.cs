using ObserverPattern.Observers.Interface;
using ObserverPattern.Subject;
using ObserverPattern.Subject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers.Observers
{
    public class CurrentConditionsDisplay : IObserver , IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private readonly WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Update(double temp, double humidity, double pressure)
        {
            _temperature= temp;
            _humidity= humidity;
            Display();
        }


        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
        }

        public void Update()
        {
            _temperature = _weatherData.GetTemperature();
            _humidity = _weatherData.GetHumidity();
            Display();
        }
    }
}
