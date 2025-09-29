using Microsoft.Extensions.DependencyInjection;
using StructuralPatterns.Facade.Subsystems;

namespace StructuralPatterns.Facade.Extensions;

// DI-Extension zum Kapseln der Registierung
public static class ServicecollectionExtensions
{
    public static IServiceCollection AddOrderFacade(this IServiceCollection services)
    {
        // Subsysteme als Transient/Singleton nach Bedarf
        services.AddTransient<InventoryService>();
        services.AddTransient<PaymentService>();
        services.AddTransient<ShippingService>();
        
        // Facade selbst
        services.AddTransient<OrderFacade>();
        
        // Consumer
        services.AddTransient<OrderController>();
        
        return services;
    }
}