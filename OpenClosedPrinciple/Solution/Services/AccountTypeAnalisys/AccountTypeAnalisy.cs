using SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.OpenClosedPrinciple.Solution.Entities;

namespace SOLID.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

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