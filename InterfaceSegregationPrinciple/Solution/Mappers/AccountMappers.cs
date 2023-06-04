using Api.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Solution.Entities;
using Api.InterfaceSegregationPrinciple.Solution.Enums;

namespace Api.InterfaceSegregationPrinciple.Solution.Mappers;

public static class AccountMappers
{
    public static AccountEntity MapToAccountEntity(this CreateAccountIspSolutionInput input) 
    {
        return new AccountEntity
        (
            password: input.Password,
            accountType: (AccountType)Enum.ToObject(typeof(AccountType), input.AccountType)
        );
    }

    public static CreateAccountIspSolutionOutput MapToOuuput(this AccountEntity accountEntity) 
    {
        return new CreateAccountIspSolutionOutput(accountEntity.AccountNumber);
    }
}