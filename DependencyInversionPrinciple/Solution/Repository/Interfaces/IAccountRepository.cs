using SOLID.DependencyInversionPrinciple.Solution.Entities;

namespace SOLID.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface IAccountRepository
    {
        bool AccountAlreadyExists(AccountEntity account);
        int CreateNewAccount(AccountEntity account);
    }
}