namespace ObserverPattern.Observer;

public interface IWeatherObserver
{
    void Update(double temperature, double humidity, double pressure);
}
