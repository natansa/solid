using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Services.Interfaces;

public interface IAccountService
{
    (bool Success, AccountEntity AccountEntity) Create(AccountEntity account);
}
