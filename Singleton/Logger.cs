namespace Singleton;

public sealed class Logger
{
    private static readonly Lazy<Logger> LazyLogger = new(() => new Logger());
    public static Logger Instance => LazyLogger.Value;

    private Logger() { }
    
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}