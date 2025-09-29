namespace CreationalPatterns.AbstractFactory;

public class NoSqlDatabaseFactory : IDatabaseFactory
{
    public IDatabase CreateDatabase()
    {
        return new NoSqlDatabase();
    }
}