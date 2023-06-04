using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces
{
    public interface IAccountQueryRepository
    {
        bool AccountAlreadyExists(AccountEntity account);
        decimal GetAccountBalance(AccountEntity account);
    }
}
