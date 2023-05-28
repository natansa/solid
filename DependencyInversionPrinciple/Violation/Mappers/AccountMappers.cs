using SOLID.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Violation.Entities;
using SOLID.DependencyInversionPrinciple.Violation.Enums;

namespace SOLID.DependencyInversionPrinciple.Violation.Mappers;

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

    public static CreateAccountOutput MapToOutput(this AccountEntity accountEntity) 
    {
        return new CreateAccountOutput(accountEntity.AccountNumber);
    }
}