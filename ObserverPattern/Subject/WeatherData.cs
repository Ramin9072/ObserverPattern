using ObserverPattern.Observers.Interface;
using ObserverPattern.Subject.Interfaces;

namespace ObserverPattern.Subject
{
    public class WeatherData : ISubject
    {
        private double _temperature { get; set; }
        private double _humidity { get; set; }
        private double _pressure { get; set; }

        private readonly List<IObserver> _observers;
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                //observer.Update(_temperature, _humidity, _pressure);
                observer.Update();
            }
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public double GetTemperature()
        {
            return _temperature;
        }
        public double GetHumidity()
        {
            return _humidity;
        }
        public double GetPressure()
        {
            return _pressure;
        }
    }
}
