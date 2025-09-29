namespace CreationalPatterns.Singleton;

public class Logger
{
    private const string APPLICATION_NAME = "C# Programming";
    private const string APPLICATION_VERSION = "1.0.0.0";

    private static Logger? _instance;

    private Logger() { }

    public static Logger GetInstance()
    {
        // Create an instance once at runtime
        _instance ??= new Logger();
        return _instance;
    }

    public void Log(string pMessage)
    {
        Console.WriteLine($"{APPLICATION_NAME} - {APPLICATION_VERSION}: pMessage");
    }
}