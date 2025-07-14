using Creational.DocumentSystem.Core;

namespace Creational.DocumentSystem.Factory;

public class ContractCreator : DocumentCreator
{
    public override IDocument CreateDocument(string title)
    {
        var contract = new Contract { Title = title };
        contract.AddClause("This is a default clause.");
        return contract;
    }
}