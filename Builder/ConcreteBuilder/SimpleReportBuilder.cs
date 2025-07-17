using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder;

public class SimpleReportBuilder : IReportBuilder
{
    private Report _report = new Report();

    public void BuildTitle()
    {
        _report.Title = "Simple Report";
    }

    public void BuildHeader()
    {
        _report.Header = "Header of Simple Report";
    }

    public void BuildContent()
    {
        _report.Content = "This is the content of the simple report.";
    }

    public void BuildFooter()
    {
        _report.Footer = "Footer of Simple Report";
    }

    public Report GetReport()
    {
        return _report;
    }
}