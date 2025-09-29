using System.Diagnostics;

namespace StructuralPatterns.Decorator.LoggingDecorator;

public class LoggingBookServiceDecorator(IBookService pDecoratedBookService) : IBookService
{
    public void AddBook(Book pBook)
    {
        // Begin logging
        Console.WriteLine($"[Logger]: Adding a Book: \"{pBook.Title}\" by \"{pBook.Author}\"");
        Stopwatch stopwatch = Stopwatch.StartNew();
        
        // Action
        pDecoratedBookService.AddBook(pBook);
        
        // End logging
        stopwatch.Stop();
        Console.WriteLine($"[Logger]: Book \"{pBook.Title}\" by \"{pBook.Author}\" added in {stopwatch.ElapsedMilliseconds} ms.");
    }
}