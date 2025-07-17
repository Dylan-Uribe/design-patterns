using FactoryMethod.DocumentationSystem.Products;

namespace FactoryMethod.DocumentationSystem.Factories;

public class WordCreator : DocumentCreator
{
    protected override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}