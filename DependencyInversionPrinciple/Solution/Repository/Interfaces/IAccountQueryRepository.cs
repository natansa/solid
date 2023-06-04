using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface IAccountQueryRepository
    {
        bool AccountAlreadyExists(AccountEntity account);
        decimal GetAccountBalance(AccountEntity account);
    }
}
