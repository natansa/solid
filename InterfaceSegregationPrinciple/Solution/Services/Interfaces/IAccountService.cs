using SOLID.InterfaceSegregationPrinciple.Solution.Entities;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

public interface IAccountService
{
    (bool Success, AccountEntity AccountEntity) Create(AccountEntity account);
}
