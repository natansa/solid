using SOLID.DependencyInversionPrinciple.Violation.Entities;

namespace SOLID.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IAccountService
{
    (bool Success, AccountEntity AccountEntity) Create(AccountEntity account);
}
