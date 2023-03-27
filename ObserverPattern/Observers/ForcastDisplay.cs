using ObserverPattern.Observers.Interface;
using ObserverPattern.Subject;
using ObserverPattern.Subject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    public class ForcastDisplay : IObserver, IDisplayElement
    {
        private double _currentPressure = 29.92d;
        private double _lastPressure;
        private readonly WeatherData _weatherData;

        public ForcastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RemoveObserver(this); // برای حذف از چرخه آبزرور
            //_weatherData.RegisterObserver(this); // برای اضافه شدن به آبزرور ها
        }

        public void Display()
        {
            Console.Write("**");
            Console.Write("Forecast: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        public void Update()
        {
            _lastPressure = _currentPressure;
            _currentPressure = _weatherData.GetPressure();

            Display();
        }
    }
}
