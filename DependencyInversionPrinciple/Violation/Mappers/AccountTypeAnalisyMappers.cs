using SOLID.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Violation.Entities;
using SOLID.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;

namespace SOLID.DependencyInversionPrinciple.Violation.Mappers;

public static class AccountTypeAnalisyMappers
{
    public static AccountTypeAnalisy MapToAnalisy(this AccountEntity accountEntity, CreateAccountInput input) 
    {
        return new AccountTypeAnalisy(input, accountEntity);
    }
}