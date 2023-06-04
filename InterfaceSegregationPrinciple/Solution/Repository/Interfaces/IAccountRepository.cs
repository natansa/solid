using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces
{
    public interface IAccountRepository
    {
        bool AccountAlreadyExists(AccountEntity account);
        int CreateNewAccount(AccountEntity account);
    }
}
