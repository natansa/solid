using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Solution.Boundaries.GetAccountBalance;
using Api.DependencyInversionPrinciple.Solution.Entities;
using Api.DependencyInversionPrinciple.Solution.Enums;

namespace Api.DependencyInversionPrinciple.Solution.Mappers;

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

    public static CreateAccountIspSolutionOutput MapToOutput(this AccountEntity accountEntity) 
    {
        return new CreateAccountIspSolutionOutput(accountEntity.AccountNumber);
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