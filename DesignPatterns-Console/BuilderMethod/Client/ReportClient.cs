using DesignPatterns_Console.BuilderMethod.ConcreateBuilder;
using DesignPatterns_Console.BuilderMethod.Director;

namespace DesignPatterns_Console.BuilderMethod.Client;

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