using SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Violation.Entities;
using SOLID.InterfaceSegregationPrinciple.Violation.Services.AccountTypeAnalisys;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Mappers;

public static class AccountTypeAnalisyMappers
{
    public static AccountTypeAnalisy MapToAnalisy(this AccountEntity accountEntity, CreateAccountIspViolationInput input) 
    {
        return new AccountTypeAnalisy(input, accountEntity);
    }
}