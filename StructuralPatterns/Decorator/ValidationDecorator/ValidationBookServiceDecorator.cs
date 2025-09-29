

using FluentValidation;

namespace StructuralPatterns.Decorator.ValidationDecorator;

public class ValidationBookServiceDecorator(IBookService pDecoratedBookService, IEnumerable<IValidator<Book>> pValidators) : IBookService
{
    public void AddBook(Book pBook)
    {
        var context = new ValidationContext<Book>(pBook);
        var failures = pValidators.Select(v => v.Validate(context))
                                  .SelectMany(result => result.Errors)
                                  .Where(f => f != null)
                                  .ToList();
        
        if (failures.Any())
            throw new ValidationException(failures);

        Console.WriteLine($"[Validator]: Book \"{pBook.Title}\" by \"{pBook.Author}\" is valid.");
        
        pDecoratedBookService.AddBook(pBook);
    }
}