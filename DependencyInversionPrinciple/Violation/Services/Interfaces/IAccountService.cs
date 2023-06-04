using Api.DependencyInversionPrinciple.Violation.Models;
using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IAccountService
{
    CreateAccountResult Create(AccountEntity account);
    AccountEntity GetAccountBalance(AccountEntity accountEntity);
}
