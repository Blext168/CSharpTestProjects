using BehavioralPatterns.Observer;
using BehavioralPatterns.Observer.ConcreteObserver;
using BehavioralPatterns.Observer.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace BehavioralPatterns;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        // Observer
        Console.WriteLine("\n----- Observer -----");
        ServiceCollection services = new();
        services.AddObserverCollection();
        ServiceProvider provider = services.BuildServiceProvider();
        
        // Hole die WeatherStation (Subject)
        IWeatherStation station = provider.GetRequiredService<IWeatherStation>();

        // Hole alle Observer-Registrierungen und registriere sie beim Subject
        IEnumerable<IObserver> observers = provider.GetServices<IObserver>();

        foreach (IObserver observer in observers)
            station.Register(observer);
        
        // Alternativ: Observer können sich auch selbst beim Subject anmelden,
        // wenn sie eine Referenz zum Subject injiziert bekommen.
        
        // Verwende den Controller, um Messungen durchzuführen
        WeatherController controller = provider.GetRequiredService<WeatherController>();
        controller.StartMeasurements(count: 3, delayMs: 500);
        
        Console.WriteLine();

        // Zugriff auf das Memory-Log (konkreter Typ)
        MemoryLoggerObserver memLogger = provider.GetRequiredService<MemoryLoggerObserver>();
        memLogger.DumpLog();
    }
}