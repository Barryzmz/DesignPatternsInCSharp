using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern.ConcreteSubject;

public sealed class WeatherStation : IWeatherSubject
{
    private readonly List<IWeatherObserver> observers = [];
    private double temperature;
    private double humidity;
    private double pressure;

    public void RegisterObserver(IWeatherObserver observer)
    {
        ArgumentNullException.ThrowIfNull(observer);

        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }
    }

    public void RemoveObserver(IWeatherObserver observer)
    {
        ArgumentNullException.ThrowIfNull(observer);
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IWeatherObserver observer in observers.ToArray())
        {
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;

        NotifyObservers();
    }
}
