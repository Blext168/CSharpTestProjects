namespace StructuralPatterns.Decorator;

public class BookService : IBookService
{
    private readonly IBookRepository _repository;

    public BookService(IBookRepository pRepository)
    {
        _repository = pRepository;
    }
    
    public void AddBook(Book pBook)
    {
        _repository.AddBook(pBook);
    }
}