using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;

public class AccountTypeAnalisy
{
    public AccountTypeAnalisy(CreateAccountIspSolutionInput input, AccountEntity accountEntity)
    {
        Input = input;
        AccountEntity = accountEntity;
    }

    public CreateAccountIspSolutionInput Input { get; }
    public AccountEntity AccountEntity { get; }
}