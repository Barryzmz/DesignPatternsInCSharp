using ObserverPattern.Observer;

namespace ObserverPattern.Subject;

public interface IWeatherSubject
{
    void RegisterObserver(IWeatherObserver observer);

    void RemoveObserver(IWeatherObserver observer);

    void NotifyObservers();
}
