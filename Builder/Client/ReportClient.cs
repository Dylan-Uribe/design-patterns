using Builder.ConcreteBuilder;
using Builder.Director;

namespace Builder.Client;

public static class ReportClient
{
    public static void Run()
    {
        var simpleReportBuilder = new SimpleReportBuilder();
        var reportDirector = new ReportDirector(simpleReportBuilder);
        var report = reportDirector.Construct();
        report.Show();
    }
}