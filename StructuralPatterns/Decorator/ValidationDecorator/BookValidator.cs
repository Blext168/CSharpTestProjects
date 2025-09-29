using FluentValidation;

namespace StructuralPatterns.Decorator.ValidationDecorator;

public class BookValidator : AbstractValidator<Book>
{
    public BookValidator()
    {
        // Ensure the Title is not empty
        RuleFor(book => book.Title)
            .NotEmpty().WithMessage("Title is required.");

        // Ensure the Author is not empty
        RuleFor(book => book.Author)
            .NotEmpty().WithMessage("Author is required.");

        // Ensure the Price is greater than 0
        RuleFor(book => book.Price)
            .GreaterThan(0).WithMessage("Price must be greater than 0.");
    }
}