using Api.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using Api.LiskovSubstitutionPrinciple.Solution.Entities;
using Api.LiskovSubstitutionPrinciple.Solution.Enums;

namespace Api.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class AccountMappers
{
    public static AccountEntity MapToAccountEntity(this CreateAccountLspSolutionInput input) 
    {
        return new AccountEntity
        (
            password: input.Password,
            accountType: (AccountType)Enum.ToObject(typeof(AccountType), input.AccountType)
        );
    }

    public static CreateAccountLspSolutionOutput MapToOuuput(this AccountEntity accountEntity) 
    {
        return new CreateAccountLspSolutionOutput(accountEntity.AccountNumber);
    }
}