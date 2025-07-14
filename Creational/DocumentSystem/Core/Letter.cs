namespace Creational.DocumentSystem.Core;

public class Letter : IDocument
{
    public string Title { get; set; }
    public string Recipient { get; set; }
    
    public Letter(string title, string recipient)
    {
        Title = title;
        Recipient = recipient;
    }
    
    public void Show()
    {
        Console.WriteLine($"[Letter] Title: {Title}, Recipient: {Recipient}");
    }
    
    public IDocument Clone()
    {
        return new Letter(Title, Recipient);
    }
}