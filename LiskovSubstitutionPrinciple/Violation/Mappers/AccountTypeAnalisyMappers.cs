using SOLID.LiskovSubstitutionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Violation.Entities;
using SOLID.LiskovSubstitutionPrinciple.Violation.Services.AccountTypeAnalisys;

namespace SOLID.LiskovSubstitutionPrinciple.Violation.Mappers;

public static class AccountTypeAnalisyMappers
{
    public static AccountTypeAnalisy MapToAnalisy(this AccountEntity accountEntity, CreateAccountInput input) 
    {
        return new AccountTypeAnalisy(input, accountEntity);
    }
}