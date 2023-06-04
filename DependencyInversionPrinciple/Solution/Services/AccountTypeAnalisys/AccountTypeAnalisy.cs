using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

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