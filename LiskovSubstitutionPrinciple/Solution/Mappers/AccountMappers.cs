using SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Solution.Entities;
using SOLID.LiskovSubstitutionPrinciple.Solution.Enums;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class AccountMappers
{
    public static AccountEntity MapToAccountEntity(this CreateAccountSolutionInput input) 
    {
        return new AccountEntity
        (
            password: input.Password,
            accountType: (AccountType)Enum.ToObject(typeof(AccountType), input.AccountType)
        );
    }

    public static CreateAccountSolutionOutput MapToOuuput(this AccountEntity accountEntity) 
    {
        return new CreateAccountSolutionOutput(accountEntity.AccountNumber);
    }
}