namespace Creational.DocumentSystem.Core;

public class DocumentManager
{
    private static DocumentManager _instance;
    public static DocumentManager Instance => _instance ??= new DocumentManager();
    
    private readonly List<IDocument> _documents = new();
    
    private DocumentManager() { }
    
    public void AddDocument(IDocument document)
    {
        _documents.Add(document);
    }

    public void ShowAll()
    {
        Console.WriteLine("Documents in the system:");
        foreach (var doc in _documents)
        {
            doc.Show();
        }
    }

    public IDocument CloneDocument(int index)
    {
        if(index < 0 || index >= _documents.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Invalid document index.");
        }
        return _documents[index].Clone();
    }
    
    public List<IDocument> GetDocuments() => _documents;
}