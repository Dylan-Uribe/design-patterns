using DesignPatterns_Console.BuilderMethod.Builder;
using DesignPatterns_Console.BuilderMethod.Product;

namespace DesignPatterns_Console.BuilderMethod.Director;

public class ReportDirector(IReportBuilder reportBuilder)
{
    /*Using primary constructor*/
    public Report Construct()
    {
        reportBuilder.BuildTitle();
        reportBuilder.BuildHeader();
        reportBuilder.BuildContent();
        reportBuilder.BuildFooter();
        return reportBuilder.GetReport();
    }
}