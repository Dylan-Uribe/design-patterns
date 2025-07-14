namespace Creational.DocumentSystem.Core;

public class Contract : IDocument
{
    public string Title { get; set; }
    public List<string> Clauses { get; set; } = new();

    public void AddClause(string clause)
    {
        Clauses.Add(clause);
    }
    
    public void Show()
    {
        Console.WriteLine($"[Contract] Title: {Title}");
        Console.WriteLine("Clauses:");
        foreach (var clause in Clauses)
        {
            Console.WriteLine($"- {clause}");
        }
    }

    public IDocument Clone()
    {
        var clone = new Contract { Title = this.Title };
        clone.Clauses = new List<string>(this.Clauses);
        return clone;
    }
}