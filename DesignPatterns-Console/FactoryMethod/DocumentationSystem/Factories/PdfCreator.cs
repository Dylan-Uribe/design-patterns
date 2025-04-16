using DesignPatterns_Console.FactoryMethod.DocumentationSystem.Products;

namespace DesignPatterns_Console.FactoryMethod.DocumentationSystem.Factories;

public class PdfCreator : DocumentCreator
{
    protected override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}