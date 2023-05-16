using SOLID.LiskovSubstitutionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Violation.Entities;
using SOLID.LiskovSubstitutionPrinciple.Violation.Enums;

namespace SOLID.LiskovSubstitutionPrinciple.Violation.Mappers;

public static class AccountMappers
{
    public static AccountEntity MapToAccountEntity(this CreateAccountInput input) 
    {
        return new AccountEntity
        (
            password: input.Password,
            accountType: (AccountType)Enum.ToObject(typeof(AccountType), input.AccountType)
        );
    }

    public static CreateAccountOutput MapToOuuput(this AccountEntity accountEntity) 
    {
        return new CreateAccountOutput(accountEntity.AccountNumber);
    }
}