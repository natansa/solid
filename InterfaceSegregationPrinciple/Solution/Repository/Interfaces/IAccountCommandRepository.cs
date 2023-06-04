using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces
{
    public interface IAccountCommandRepository
    {
        int CreateNewAccount(AccountEntity account);
    }
}