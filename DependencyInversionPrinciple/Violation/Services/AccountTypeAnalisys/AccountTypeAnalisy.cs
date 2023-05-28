using SOLID.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Violation.Entities;

namespace SOLID.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;

public class AccountTypeAnalisy
{
    public AccountTypeAnalisy(CreateAccountInput input, AccountEntity accountEntity)
    {
        Input = input;
        AccountEntity = accountEntity;
    }

    public CreateAccountInput Input { get; }
    public AccountEntity AccountEntity { get; }
}