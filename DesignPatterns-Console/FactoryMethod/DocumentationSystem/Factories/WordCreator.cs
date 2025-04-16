using DesignPatterns_Console.FactoryMethod.DocumentationSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.DocumentationSystem.Factories;

public class WordCreator : DocumentCreator
{
    protected override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}