using Api.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using Api.OpenClosedPrinciple.Solution.Entities;
using Api.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.OpenClosedPrinciple.Solution.Mappers;

public static class AccountTypeAnalisyMappers
{
    public static AccountTypeAnalisy MapToAnalisy(this AccountEntity accountEntity, CreateAccountOcpSolutionInput input) 
    {
        return new AccountTypeAnalisy(input, accountEntity);
    }
}