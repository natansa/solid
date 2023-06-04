using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface IAccountCommandRepository
    {
        int CreateNewAccount(AccountEntity account);
    }
}