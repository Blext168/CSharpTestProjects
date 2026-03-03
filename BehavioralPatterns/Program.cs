using BehavioralPatterns.Observer;
using BehavioralPatterns.Observer.ConcreteObserver;
using BehavioralPatterns.Observer.Extensions;
using BehavioralPatterns.Strategy;
using BehavioralPatterns.Strategy.Extensions;
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
        
        // Strategy
        Console.WriteLine("\n----- Strategy -----");
        ServiceCollection strategyServices = new();
        strategyServices.AddShippingStrategies();
        ServiceProvider strategyProvider = strategyServices.BuildServiceProvider();
        
        ShippingCalculator calculator = strategyProvider.GetRequiredService<ShippingCalculator>();
        Func<string, IShippingStrategy> strategyFactory = strategyProvider.GetRequiredService<Func<string, IShippingStrategy>>();

        // Beispielwerte
        decimal weight = 4.65M; // kg
        decimal distance = 19.7M; // km

        Console.WriteLine($"Standard (Default) Strategie: Kosten = {calculator.CalculateCost(weight, distance):C}");
        
        // Laufzeitwechsel: Wähle andere Strategie aus der Factory
        IShippingStrategy air = strategyFactory("air");
        calculator.SetStrategy(air);
        Console.WriteLine($"Air Strategie: Kosten = {calculator.CalculateCost(weight, distance):C}");
        
        try
        {
            IShippingStrategy drone = strategyFactory("drone");
            calculator.SetStrategy(drone);
            Console.WriteLine($"Drone Strategie: Kosten = {calculator.CalculateCost(weight, distance):C}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Drone Strategie konnte nicht angewandt werden: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("Verfügbare Strategien:");
        foreach (IShippingStrategy s in strategyProvider.GetServices<IShippingStrategy>())
            Console.WriteLine($" - {s.Name}");
    }
}