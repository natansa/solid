using Api.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Solution.Entities;
using Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.InterfaceSegregationPrinciple.Solution.Mappers;

public static class AccountTypeAnalisyMappers
{
    public static AccountTypeAnalisy MapToAnalisy(this AccountEntity accountEntity, CreateAccountIspSolutionInput input) 
    {
        return new AccountTypeAnalisy(input, accountEntity);
    }
}