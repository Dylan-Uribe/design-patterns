using DesignPatterns_Console.FactoryMethod.DocumentationSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.DocumentationSystem.Factories;

public abstract class DocumentCreator
{
    protected abstract IDocument CreateDocument();

    public void GenerateDocument()
    {
        IDocument document = CreateDocument();
        document.Generate();
    }
}