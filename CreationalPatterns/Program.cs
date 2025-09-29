using System.Reflection;
using CreationalPatterns.AbstractFactory;
using CreationalPatterns.Builder;
using CreationalPatterns.FactoryMethod;
using CreationalPatterns.Singleton;

namespace CreationalPatterns;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        
        // Singleton
        Console.WriteLine("\n---Singleton---");
        Logger logger = Logger.GetInstance();
        logger.Log("Hello World!");
        
        // Factory Method
        Console.WriteLine("\n---Factory Method---");
        IProductFactory productFactory = new MentoringFactory();
        IProduct mentoring = productFactory.CreateProduct();
        mentoring.DisplayDetails();

        IProductFactory productFactory2 = new TrainingFactory();
        IProduct training = productFactory2.CreateProduct();
        training.DisplayDetails();  
        
        // Abstract 
        Console.WriteLine("\n---Abstract Factory---");
        IDatabaseFactory abstractFactory = new NoSqlDatabaseFactory();
        IDatabase noSqlDatabase = abstractFactory.CreateDatabase();
        noSqlDatabase.Connect();
        
        IDatabaseFactory abstractFactory2 = new SqlDatabaseFactory();
        IDatabase sqlDatabase = abstractFactory2.CreateDatabase();
        sqlDatabase.Connect();
        
        // Builder
        Console.WriteLine("\n---Builder---");
        Address address = new AddressBuilder().WithName("Danilo Schiefer")
                                              .WithStreet("Kieler Str. 68")
                                              .WithZipCode("26382")
                                              .WithCity("Wilhelmshaven")
                                              .WithState("Deutschland")
                                              .Build();
        Console.WriteLine($"{address.Fullname}\n{address.Street}\n{address.ZipCode} {address.City}\n{address.State}");
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(Assembly.GetExecutingAssembly().GetName().Version.ToString());
    }
}