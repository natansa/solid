using Api.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using Api.OpenClosedPrinciple.Solution.Entities;

namespace Api.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

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