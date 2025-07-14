namespace Structural.AdapterPattern.Legacy;

public class LegacyPrinter
{
    public void Write(string message)
    {
        Console.WriteLine($"Legacy Printer: {message}");
    }
}