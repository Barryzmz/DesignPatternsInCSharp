using ObserverPattern.Observer;

namespace ObserverPattern.ConcreteObserver;

public sealed class CurrentConditionsDisplay : IWeatherObserver
{
    public void Update(double temperature, double humidity, double pressure)
    {
        Console.WriteLine($"Current conditions: {temperature:F1} °C, humidity {humidity:F1}%");
    }
}
