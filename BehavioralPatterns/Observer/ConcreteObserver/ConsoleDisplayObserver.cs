namespace BehavioralPatterns.Observer.ConcreteObserver;

// Concrete Observer 1: Anzeige in der Konsole
public class ConsoleDisplayObserver : IObserver
{
    public void Update(double pTemperatureCelsius)
    {
        Console.WriteLine($"[ConsoleDisplayObserver]: Aktuelle Temperature: {pTemperatureCelsius:F2}°C");
    }
}