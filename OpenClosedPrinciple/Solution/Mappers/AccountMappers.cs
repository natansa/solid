using Api.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using Api.OpenClosedPrinciple.Solution.Entities;
using Api.OpenClosedPrinciple.Solution.Enums;

namespace Api.OpenClosedPrinciple.Solution.Mappers;

public static class AccountMappers
{
    public static AccountEntity MapToAccountEntity(this CreateAccountOcpSolutionInput input) 
    {
        return new AccountEntity
        (
            password: input.Password,
            accountType: (AccountType)Enum.ToObject(typeof(AccountType), input.AccountType)
        );
    }

    public static CreateAccountOcpSolutionOutput MapToOutput(this AccountEntity accountEntity) 
    {
        return new CreateAccountOcpSolutionOutput(accountEntity.AccountNumber);
    }
}