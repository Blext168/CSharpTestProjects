using Microsoft.Extensions.DependencyInjection;

namespace StructuralPatterns.Adapter.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAdaptedTemperatureSensor(this IServiceCollection services)
    {
        // Registriere die Legacy-Klasse
        services.AddTransient<LegacyFahrenheitSensor>();
        // Registriere die Adapter-Implementierung der Ziel-Schnittstelle
        services.AddTransient<ITemperatureSensor>(sp =>
        {
            var legacy = sp.GetRequiredService<LegacyFahrenheitSensor>();
            return new FahrenheitToCelsiusAdapter(legacy);
        });
        
        // Optional: registriere den Consumer
        services.AddTransient<DisplayTemperature>();
        
        return services;
    }
}