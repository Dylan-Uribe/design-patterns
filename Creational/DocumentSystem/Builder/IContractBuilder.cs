using Creational.DocumentSystem.Core;

namespace Creational.DocumentSystem.Builder;

public interface IContractBuilder
{
    void SetTitle(string title);
    void AddClause(string clause);
    Contract GetContract();
}