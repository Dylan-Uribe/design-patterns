using Builder.Builder;
using Builder.Product;

namespace Builder.Director;

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