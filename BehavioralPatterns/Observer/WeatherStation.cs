namespace BehavioralPatterns.Observer;

public class WeatherStation : IWeatherStation
{
    private readonly List<IObserver> _observers = [];
    private readonly Random _rnd = new();
    
    public double TemperatureCelsius { get; private set; }
    
    public void Register(IObserver pObserver)
    {
        if (!_observers.Contains(pObserver))
            _observers.Add(pObserver);
    }

    public void Unregister(IObserver pObserver)
    {
        _observers.Remove(pObserver);
    }

    public void Notify()
    {
        foreach (IObserver observer in _observers)
            observer.Update(TemperatureCelsius);
    }

    public void Measure()
    {
        // Temperatur zwischen -10!C und 35°C
        TemperatureCelsius = -10 + _rnd.NextDouble() * 45;
        Console.WriteLine($"[WeatherStation]: Neue Messung: {TemperatureCelsius:F2}°C");
        Notify();
    }
}