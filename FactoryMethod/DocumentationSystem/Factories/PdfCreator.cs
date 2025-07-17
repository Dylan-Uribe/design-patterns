using FactoryMethod.DocumentationSystem.Products;

namespace FactoryMethod.DocumentationSystem.Factories;

public class PdfCreator : DocumentCreator
{
    protected override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}