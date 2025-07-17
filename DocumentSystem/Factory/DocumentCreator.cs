using DocumentSystem.Core;

namespace DocumentSystem.Factory;

public abstract class DocumentCreator
{
    public abstract IDocument CreateDocument(string title);
}