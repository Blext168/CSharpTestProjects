namespace CreationalPatterns.AbstractFactory;

public class SqlDatabaseFactory : IDatabaseFactory
{
    public IDatabase CreateDatabase()
    {
        return new SqlDatabase();
    }
}