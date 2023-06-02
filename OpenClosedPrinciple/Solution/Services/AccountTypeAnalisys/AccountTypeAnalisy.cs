using SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.OpenClosedPrinciple.Solution.Entities;

namespace SOLID.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

public class AccountTypeAnalisy
{
    public AccountTypeAnalisy(CreateAccountOcpSolutionInput input, AccountEntity accountEntity)
    {
        Input = input;
        AccountEntity = accountEntity;
    }

    public CreateAccountOcpSolutionInput Input { get; }
    public AccountEntity AccountEntity { get; }
}