using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface IAccountRepository
    {
        bool AccountAlreadyExists(AccountEntity account);
        int CreateNewAccount(AccountEntity account);
    }
}