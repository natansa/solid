using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository.Interfaces
{
    public interface IAccountQueryRepository
    {
        bool AccountAlreadyExists(AccountEntity account);
        decimal GetAccountBalance(AccountEntity account);
    }
}
