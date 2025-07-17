using FactoryMethod.DocumentationSystem.Factories;

namespace FactoryMethod.DocumentationSystem.Client;

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