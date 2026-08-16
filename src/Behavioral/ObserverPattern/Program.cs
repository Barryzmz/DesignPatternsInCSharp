using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubject;

WeatherStation weatherStation = new();

CurrentConditionsDisplay currentConditionsDisplay = new();
StatisticsDisplay statisticsDisplay = new();
ForecastDisplay forecastDisplay = new();

weatherStation.RegisterObserver(currentConditionsDisplay);
weatherStation.RegisterObserver(statisticsDisplay);
weatherStation.RegisterObserver(forecastDisplay);

Console.WriteLine("========== First update ==========");
weatherStation.SetMeasurements(25.5, 65, 1013);

Console.WriteLine("\n========== Second update ==========");
weatherStation.SetMeasurements(28, 70, 1008);

Console.WriteLine("\n========== Remove forecast display ==========");
weatherStation.RemoveObserver(forecastDisplay);

Console.WriteLine("\n========== Third update ==========");
weatherStation.SetMeasurements(22, 90, 1005);
