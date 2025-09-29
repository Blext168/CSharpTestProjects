namespace CreationalPatterns.AbstractFactory;

public class NoSqlDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connected to NoSQL Database.");
    }
}