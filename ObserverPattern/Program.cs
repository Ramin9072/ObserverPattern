using ObserverPattern.Observers;
using ObserverPattern.Observers.Observers;
using ObserverPattern.Subject;

public class Program
{

    // با اضافه کردن کلاس جدید برای وضعیت آب و هوا دیگر نیازی نیست از آبجکت هر کدام از کلاس های نیو شده استفاده کنیم 
    private static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        ForcastDisplay forcastDisplay = new ForcastDisplay(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4d);
        weatherData.SetMeasurements(82, 70, 29.2d);
        weatherData.SetMeasurements(78, 90, 29.2d);

        Console.ReadLine();

    }
}