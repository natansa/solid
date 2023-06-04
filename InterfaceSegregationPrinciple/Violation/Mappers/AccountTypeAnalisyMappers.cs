using Api.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Violation.Entities;
using Api.InterfaceSegregationPrinciple.Violation.Services.AccountTypeAnalisys;

namespace Api.InterfaceSegregationPrinciple.Violation.Mappers;

public static class AccountTypeAnalisyMappers
{
    public static AccountTypeAnalisy MapToAnalisy(this AccountEntity accountEntity, CreateAccountIspViolationInput input) 
    {
        return new AccountTypeAnalisy(input, accountEntity);
    }
}