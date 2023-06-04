using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.Entities;
using Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;

namespace Api.DependencyInversionPrinciple.Violation.Mappers;

public static class AccountTypeAnalisyMappers
{
    public static AccountTypeAnalisy MapToAnalisy(this AccountEntity accountEntity, CreateAccountDipViolationInput input) 
    {
        return new AccountTypeAnalisy(input, accountEntity);
    }
}