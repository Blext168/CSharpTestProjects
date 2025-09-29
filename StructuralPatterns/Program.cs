using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StructuralPatterns.Adapter;
using StructuralPatterns.Adapter.Extensions;
using StructuralPatterns.Decorator;
using StructuralPatterns.Decorator.ServiceRegistration;
using StructuralPatterns.Facade;
using StructuralPatterns.Facade.Extensions;

namespace StructuralPatterns;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        // Adapter
        Console.WriteLine("\n-----Adapter-----");
        ServiceCollection adapterServices = new();
        
        // Variante 1: Manuelle Registierung:
        adapterServices.AddTransient<LegacyFahrenheitSensor>();
        adapterServices.AddTransient<ITemperatureSensor>(sp =>
        {
            LegacyFahrenheitSensor legacy = sp.GetRequiredService<LegacyFahrenheitSensor>();
            return new FahrenheitToCelsiusAdapter(legacy);
        });
        
        adapterServices.AddTransient<DisplayTemperature>();
        ServiceProvider provider = adapterServices.BuildServiceProvider();
        DisplayTemperature display = provider.GetRequiredService<DisplayTemperature>();
        display.Show();
        
        // Variante 2: Verwendung der Extension-Methode zur Kapselung
        adapterServices.AddAdaptedTemperatureSensor();
        ServiceProvider adapterProvider = adapterServices.BuildServiceProvider();
        DisplayTemperature adapterDisplay = adapterProvider.GetRequiredService<DisplayTemperature>();
        adapterDisplay.Show();
        
        // Decorator
        Console.WriteLine("\n-----Decorator-----");
        HostApplicationBuilder decoratorBuilder = Host.CreateApplicationBuilder(args);
        IServiceCollection decoratorServices = DecoratorServices.RegisterServices(decoratorBuilder.Services);

        ServiceProvider decoratorProvider = decoratorServices.BuildServiceProvider();
        IBookService? decoratorService = decoratorProvider.GetService<IBookService>();
        decoratorService?.AddBook(new Book
        {
            Title = "Decorator Pattern in C#",
            Author = "Danilo Schiefer",
            Price = 12.99M
        });
        
        // Facade
        Console.WriteLine("\n-----Facade-----");
        // Setup DI-Container
        ServiceCollection facadeServices = new();
        facadeServices.AddOrderFacade();
        ServiceProvider facadeProvider = facadeServices.BuildServiceProvider();
        
        // Consumer verwendet die Facade und bleibt dabei leicht und unabhängig
        OrderController controller = facadeProvider.GetRequiredService<OrderController>();
        controller.CreateOrder();
    }
}