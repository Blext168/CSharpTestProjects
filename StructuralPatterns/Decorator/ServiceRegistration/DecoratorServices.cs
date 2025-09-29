using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StructuralPatterns.Decorator.LoggingDecorator;
using StructuralPatterns.Decorator.ValidationDecorator;

namespace StructuralPatterns.Decorator.ServiceRegistration;

internal abstract class DecoratorServices
{
    internal static IServiceCollection RegisterServices(IServiceCollection pServices)
    {
        // Register the base service and dependencies
        pServices.AddScoped<IBookRepository, BookRepository>();
        pServices.AddSingleton<IValidator<Book>, BookValidator>();
        
        // Register the BookService as a transient or scoped service, depending on your needs,
        // but don't expose it via any interface directly to ensure it's wrapped by decorators.
        pServices.AddScoped<BookService>();
        
        // Register the decorators
        // Note: The order of registration matters for decorators, last registered is the outermost.
        pServices.AddScoped<IBookService>(pProvider =>
        {
            BookService baseService = pProvider.GetRequiredService<BookService>();
            IEnumerable<IValidator<Book>> validators = pProvider.GetRequiredService<IEnumerable<IValidator<Book>>>();
            
            // First, wrap the base service with the validation decorator
            ValidationBookServiceDecorator validationDecorator = new(baseService, validators);
            
            // Then, wrap the validation decorator with the logging decorator
            LoggingBookServiceDecorator loggingDecorator = new(validationDecorator);

            return loggingDecorator;
        });

        return pServices;
    }
}