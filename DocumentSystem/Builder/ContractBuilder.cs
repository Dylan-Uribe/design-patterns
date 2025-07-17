using DocumentSystem.Core;

namespace DocumentSystem.Builder;

public class ContractBuilder : IContractBuilder
{
    private readonly Contract _contract = new();
    
    public void SetTitle(string title)
    {
        _contract.Title = title;
    }
    
    public void AddClause(string clause)
    {
        _contract.Clauses.Add(clause);
    }
    
    public Contract GetContract()
    {
        return _contract;
    }
}