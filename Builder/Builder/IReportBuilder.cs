using Builder.Product;

namespace Builder.Builder;

public interface IReportBuilder
{
    void BuildTitle();
    void BuildHeader();
    void BuildContent();
    void BuildFooter();
    Report GetReport();
}