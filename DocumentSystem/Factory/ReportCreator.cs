using DocumentSystem.Core;

namespace DocumentSystem.Factory;

public class ReportCreator : DocumentCreator
{
    public override IDocument CreateDocument(string title)
    {
        return new Report(title, "This is a default summary");
    }
}