namespace FactoryMethod.DocumentationSystem.Products;

public class PdfDocument : IDocument
{
    public void Generate()
    {
        Console.WriteLine("Generating PDF document...");
    }
}