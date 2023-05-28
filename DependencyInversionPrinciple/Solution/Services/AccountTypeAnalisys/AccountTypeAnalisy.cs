using SOLID.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Solution.Entities;

namespace SOLID.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

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