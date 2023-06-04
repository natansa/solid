using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository.Interfaces
{
    public interface IAccountCommandRepository
    {
        int CreateNewAccount(AccountEntity account);
    }
}