using Api.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Violation.Boundaries.GetAccountBalance;
using Api.InterfaceSegregationPrinciple.Violation.Entities;
using Api.InterfaceSegregationPrinciple.Violation.Enums;

namespace Api.InterfaceSegregationPrinciple.Violation.Mappers;

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

    public static CreateAccountIspViolationOutput MapToOutput(this AccountEntity accountEntity) 
    {
        return new CreateAccountIspViolationOutput(accountEntity.AccountNumber);
    }

    public static AccountEntity MapToAccountEntity(this GetAccountBalanceInput input)
    {
        return new AccountEntity
        (
            accountNumber: input.AccountNumber
        );
    }

    public static GetAccountBalanceOutput MapToOutputAccountBalance(this AccountEntity accountEntity)
    {
        return new GetAccountBalanceOutput
        (
            accountBalance: accountEntity.AccountBalance
        );
    }
}