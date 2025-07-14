using Creational.DocumentSystem.Core;

namespace Creational.DocumentSystem.Factory;

public abstract class DocumentCreator
{
    public abstract IDocument CreateDocument(string title);
}