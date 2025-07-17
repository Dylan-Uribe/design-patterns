using DocumentSystem.Core;

namespace DocumentSystem.Builder;

public interface IContractBuilder
{
    void SetTitle(string title);
    void AddClause(string clause);
    Contract GetContract();
}