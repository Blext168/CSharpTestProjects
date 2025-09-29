namespace CreationalPatterns.FactoryMethod;

public class TrainingOffering : IProduct
{
    public void DisplayDetails()
    {
        Console.WriteLine("This is a training offering.");
    }
}