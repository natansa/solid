using Api.DependencyInversionPrinciple.Solution.Models;
using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Services.Interfaces;

public interface IAccountService
{
    CreateAccountResult Create(AccountEntity account);
    AccountEntity GetAccountBalance(AccountEntity accountEntity);
}
