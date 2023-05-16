using SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.OpenClosedPrinciple.Solution.Entities;
using SOLID.OpenClosedPrinciple.Solution.Enums;

namespace SOLID.OpenClosedPrinciple.Solution.Mappers;

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