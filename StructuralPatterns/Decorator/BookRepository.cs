namespace StructuralPatterns.Decorator;

public class BookRepository : IBookRepository
{
    public void AddBook(Book pBook)
    {
        Console.WriteLine($"[Repository]: Added Book: \"{pBook.Title}\" by \"{pBook.Author}\" for {pBook.Price} €");
    }
}