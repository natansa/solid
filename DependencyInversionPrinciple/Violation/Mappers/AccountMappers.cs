using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.Boundaries.GetAccountBalance;
using Api.DependencyInversionPrinciple.Violation.Entities;
using Api.DependencyInversionPrinciple.Violation.Enums;

namespace Api.DependencyInversionPrinciple.Violation.Mappers;

public static class AccountMappers
{
    public static AccountEntity MapToAccountEntity(this CreateAccountDipViolationInput input) 
    {
        return new AccountEntity
        (
            password: input.Password,
            accountType: (AccountType)Enum.ToObject(typeof(AccountType), input.AccountType)
        );
    }

    public static CreateAccountDipViolationOutput MapToOutput(this AccountEntity accountEntity) 
    {
        return new CreateAccountDipViolationOutput(accountEntity.AccountNumber);
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