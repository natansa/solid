using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Solution.Entities;
using SOLID.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Mappers;

public static class AccountTypeAnalisyMappers
{
    public static AccountTypeAnalisy MapToAnalisy(this AccountEntity accountEntity, CreateAccountInput input) 
    {
        return new AccountTypeAnalisy(input, accountEntity);
    }
}