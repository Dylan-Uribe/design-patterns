using FactoryMethod.DocumentationSystem.Products;

namespace FactoryMethod.DocumentationSystem.Factories;

public abstract class DocumentCreator
{
    protected abstract IDocument CreateDocument();

    public void GenerateDocument()
    {
        IDocument document = CreateDocument();
        document.Generate();
    }
}