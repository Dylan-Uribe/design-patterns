namespace DesignPatterns_Console.FactoryMethod.DocumentationSystem.Products;

public class WordDocument : IDocument
{
    public void Generate()
    {
        Console.WriteLine("Generating Word document...");
    }
}