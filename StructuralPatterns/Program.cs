using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StructuralPatterns.Decorator;
using StructuralPatterns.Decorator.ServiceRegistration;

namespace StructuralPatterns;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        // Decorator
        Console.WriteLine("\n-----Decorator-----");
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
        IServiceCollection services = DecoratorServices.RegisterServices(builder.Services);

        ServiceProvider provider = services.BuildServiceProvider();
        IBookService? service = provider.GetService<IBookService>();
        service?.AddBook(new Book
        {
            Title = "Decorator Pattern in C#",
            Author = "Danilo Schiefer",
            Price = 12.99M
        });
    }
}