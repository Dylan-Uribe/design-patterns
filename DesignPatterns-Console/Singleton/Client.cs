namespace DesignPatterns_Console.Singleton;

public static class Client
{
    public static void Run()
    {
        var logger = Logger.Instance;
        logger.Log("This is a log message.");
        
        var logger2 = Logger.Instance;
        logger2.Log("This is another log message.");
    }
}