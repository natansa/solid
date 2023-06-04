using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IAccountService
{
    (bool Success, AccountEntity AccountEntity) Create(AccountEntity account);
}
