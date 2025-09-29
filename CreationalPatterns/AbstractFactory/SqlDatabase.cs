namespace CreationalPatterns.AbstractFactory;

public class SqlDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connected to SQL Database.");
    }
}