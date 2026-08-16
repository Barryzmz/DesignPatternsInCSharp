using ObserverPattern.Observer;

namespace ObserverPattern.ConcreteObserver;

public sealed class ForecastDisplay : IWeatherObserver
{
    private double? previousPressure;

    public void Update(double temperature, double humidity, double pressure)
    {
        string forecast = previousPressure switch
        {
            null => "Waiting for more data...",
            double value when pressure > value => "Improving weather.",
            double value when pressure < value => "Rain is coming.",
            _ => "More of the same."
        };

        previousPressure = pressure;
        Console.WriteLine($"Forecast: {forecast}");
    }
}
