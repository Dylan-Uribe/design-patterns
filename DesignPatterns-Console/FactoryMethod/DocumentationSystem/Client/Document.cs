using DesignPatterns_Console.FactoryMethod.DocumentationSystem.Factories;

namespace DesignPatterns_Console.FactoryMethod.DocumentationSystem.Client;

public abstract class Document
{
    public static void Run()
    {
        DocumentCreator wordCreator = new WordCreator();
        wordCreator.GenerateDocument();
        
        DocumentCreator pdfCreator = new PdfCreator();
        pdfCreator.GenerateDocument();
    }
}