namespace CreationalPatterns.FactoryMethod;

public class MentoringOpportunity : IProduct
{
    public void DisplayDetails()
    {
        Console.WriteLine("This is a mentoring opportunity.");
    }
}