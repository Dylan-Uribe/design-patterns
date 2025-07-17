namespace DocumentSystem.Builder;

public class ContractDirector
{
    private readonly IContractBuilder _contractBuilder;
    
    public ContractDirector(IContractBuilder contractBuilder)
    {
        _contractBuilder = contractBuilder;
    }
    
    public void Construct()
    {
        _contractBuilder.SetTitle("Contract Agreement");
        _contractBuilder.AddClause("Clause 1: The parties agree to the terms outlined herein.");
        _contractBuilder.AddClause("Clause 2: The contract is effective upon signing by both parties.");
    }
}