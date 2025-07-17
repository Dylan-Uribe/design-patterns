using DocumentSystem.Core;

namespace DocumentSystem.Factory;

public class LetterCreator : DocumentCreator
{
    public override IDocument CreateDocument(string title)
    {
        return new Letter(title, "John Doe");
    }
}