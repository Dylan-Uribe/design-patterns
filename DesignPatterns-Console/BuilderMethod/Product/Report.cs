namespace DesignPatterns_Console.BuilderMethod.Product;

public class Report
{
    public string Title { get; set; } = string.Empty;
    public string Header { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Footer { get; set; } = string.Empty;

    /*Instead of doing this, maybe it is better to iterate in a list, so the
     properties printed are not static,
     they are dynamic*/
    public void Show()
    {
        Console.WriteLine("Report:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Header: {Header}");
        Console.WriteLine($"Content: {Content}");
        Console.WriteLine($"Footer: {Footer}");
        Console.WriteLine("------------------------------------");
    }
}