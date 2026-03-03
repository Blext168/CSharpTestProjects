namespace BehavioralPatterns.Observer.ConcreteObserver;

// Concrete Observer 2: Einfache Logging-Implementierung (schreibt in eine Liste)
public class MemoryLoggerObserver : IObserver
{
    private readonly List<string> _log = [];
    
    public void Update(double pTemperatureCelsius)
    {
        string line = $"{DateTime.Now:O} - Temp: {pTemperatureCelsius:F2}°C";
        _log.Add(line);
        Console.WriteLine($"[MemoryLogger]: Geloggt: {line}");
    }

    // Hilfsmethode zum Ausgeben der gesammelten Logs
    public void DumpLog()
    {
        Console.WriteLine("--- MemoryLogger Dump ---");
        foreach (string line in _log)
            Console.WriteLine(line);

        Console.WriteLine("---     Ende Dump     ---");
    }
}