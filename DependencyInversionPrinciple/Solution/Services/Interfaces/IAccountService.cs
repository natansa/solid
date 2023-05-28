using SOLID.DependencyInversionPrinciple.Solution.Entities;

namespace SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces;

public interface IAccountService
{
    (bool Success, AccountEntity AccountEntity) Create(AccountEntity account);
}
