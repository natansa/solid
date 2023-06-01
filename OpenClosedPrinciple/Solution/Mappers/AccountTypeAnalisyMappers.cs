using SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.OpenClosedPrinciple.Solution.Entities;
using SOLID.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

namespace SOLID.OpenClosedPrinciple.Solution.Mappers;

public static class AccountTypeAnalisyMappers
{
    public static AccountTypeAnalisy MapToAnalisy(this AccountEntity accountEntity, CreateAccountSolutionInput input) 
    {
        return new AccountTypeAnalisy(input, accountEntity);
    }
}