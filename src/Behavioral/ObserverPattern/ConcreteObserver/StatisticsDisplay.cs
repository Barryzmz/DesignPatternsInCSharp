using ObserverPattern.Observer;

namespace ObserverPattern.ConcreteObserver;

public sealed class StatisticsDisplay : IWeatherObserver
{
    private double maximumTemperature = double.MinValue;
    private double minimumTemperature = double.MaxValue;
    private double totalTemperature;
    private int measurementCount;

    public void Update(double temperature, double humidity, double pressure)
    {
        totalTemperature += temperature;
        measurementCount++;
        maximumTemperature = Math.Max(maximumTemperature, temperature);
        minimumTemperature = Math.Min(minimumTemperature, temperature);

        Console.WriteLine(
            $"Statistics: average {totalTemperature / measurementCount:F1} °C, " +
            $"maximum {maximumTemperature:F1} °C, minimum {minimumTemperature:F1} °C");
    }
}
