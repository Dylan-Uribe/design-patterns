namespace DocumentSystem.Core;

public class Report : IDocument
{
    public string Title { get; set; }
    public string Summary { get; set; }

    public Report(string title, string summary)
    {
        Title = title;
        Summary = summary;
    }

    public void Show()
    {
        Console.WriteLine($"[Report] Title: {Title}, Summary: {Summary}");
    }
    
    public IDocument Clone()
    {
        return new Report(Title, Summary);
    }
}