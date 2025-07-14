using Creational.DocumentSystem.Core;

namespace Creational.DocumentSystem.Factory;

public class ReportCreator : DocumentCreator
{
    public override IDocument CreateDocument(string title)
    {
        return new Report(title, "This is a default summary");
    }
}