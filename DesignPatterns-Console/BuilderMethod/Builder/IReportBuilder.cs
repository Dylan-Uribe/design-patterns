using DesignPatterns_Console.BuilderMethod.Product;

namespace DesignPatterns_Console.BuilderMethod.Builder;

public interface IReportBuilder
{
    void BuildTitle();
    void BuildHeader();
    void BuildContent();
    void BuildFooter();
    Report GetReport();
}