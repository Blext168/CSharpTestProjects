namespace BehavioralPatterns.Observer;

// Subject / Observerable
public interface IWeatherStation
{
    double TemperatureCelsius { get; }
    
    void Register(IObserver pObserver);
    void Unregister(IObserver pObserver);
    void Notify();
    void Measure();
}