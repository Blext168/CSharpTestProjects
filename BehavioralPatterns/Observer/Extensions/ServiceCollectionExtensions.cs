using BehavioralPatterns.Observer.ConcreteObserver;
using Microsoft.Extensions.DependencyInjection;

namespace BehavioralPatterns.Observer.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddObserverCollection(this IServiceCollection services)
    {
        // Wetterstation als Singleton, weil sie den Zustand hält und mehrere Observer haben kann
        services.AddSingleton<IWeatherStation, WeatherStation>();
        
        // Observer als Transient oder Singleton, je nach gewünschter Lebenszeit
        services.AddTransient<IObserver, ConsoleDisplayObserver>();
        services.AddSingleton<MemoryLoggerObserver>();
        // MemoryLoggerObserver wird hier zusätzlich als konkreter Typ registriert,
        // sodass wir später darauf zugreifen und das Log ausgeben können
        services.AddTransient<IObserver>(sp => sp.GetRequiredService<MemoryLoggerObserver>());
        
        // Contoller
        services.AddTransient<WeatherController>();
        
        return services;
    }
}