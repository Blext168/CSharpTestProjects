using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StructuralPatterns.Adapter;
using StructuralPatterns.Adapter.Extensions;
using StructuralPatterns.Decorator;
using StructuralPatterns.Decorator.ServiceRegistration;

namespace StructuralPatterns;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        // Adapter
        Console.WriteLine("\n-----Adapter-----");
        ServiceCollection adapterServices = new();
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
    }
}