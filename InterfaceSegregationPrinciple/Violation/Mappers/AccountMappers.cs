using SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Violation.Entities;
using SOLID.InterfaceSegregationPrinciple.Violation.Enums;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Mappers;

public static class AccountMappers
{
    public static AccountEntity MapToAccountEntity(this CreateAccountIspViolationInput input) 
    {
        return new AccountEntity
        (
            password: input.Password,
            accountType: (AccountType)Enum.ToObject(typeof(AccountType), input.AccountType)
        );
    }

    public static CreateAccountIspViolationOutput MapToOuuput(this AccountEntity accountEntity) 
    {
        return new CreateAccountIspViolationOutput(accountEntity.AccountNumber);
    }
}