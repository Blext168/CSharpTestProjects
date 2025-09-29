namespace StructuralPatterns.Decorator;

public class Book
{
    public string Title {get; set;} = string.Empty;
    public string Author {get; set;} = string.Empty;
    public decimal Price {get; set;}

    public override string ToString()
    {
        return $"{Title} by {Author} for ${Price.ToString("F2")}";
    }
}