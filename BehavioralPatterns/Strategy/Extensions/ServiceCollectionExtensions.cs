using BehavioralPatterns.Strategy.Strategies;
using Microsoft.Extensions.DependencyInjection;

namespace BehavioralPatterns.Strategy.Extensions;

// DI-Extensions zur registrierung mehrerer Strategien
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddShippingStrategies(this IServiceCollection services)
    {
        // Alle konkreten Strategien registrieren
        services.AddTransient<IShippingStrategy, GroundShippingStrategy>();
        services.AddTransient<IShippingStrategy, AirShippingStrategy>();
        services.AddTransient<IShippingStrategy, DroneShippingStrategy>();
        
        // ShippingCalculator wird mit einer Default-Strategie (Groud) registriert
        services.AddTransient<ShippingCalculator>(sp =>
        {
            // Wähle die erste Strategie namens "Ground" als Default
            IEnumerable<IShippingStrategy> strategies = sp.GetServices<IShippingStrategy>();
            IShippingStrategy defaultStrategy = FindByName(strategies, "Ground");
            return new ShippingCalculator(defaultStrategy);
        });
        
        // Hilfs-Fabrik für die Laufzeitauswahl: resolve by name
        services.AddSingleton<Func<string, IShippingStrategy>>(sp => name =>
        {
            IEnumerable<IShippingStrategy> strategies = sp.GetServices<IShippingStrategy>();
            return FindByName(strategies, name);
        });

        return services;
    }
    
    private static IShippingStrategy FindByName(IEnumerable<IShippingStrategy> pStrategies, string pName)
    {
        foreach(IShippingStrategy strategy in pStrategies)
            if (string.Equals(strategy.Name, pName, StringComparison.OrdinalIgnoreCase))
                return strategy;
        
        // fallback: erste verfügbare Strategie
        foreach (IShippingStrategy strategy in pStrategies)
            return strategy;
        
        throw new InvalidOperationException("Keine ShippingStrategy registriert.");
    }
}