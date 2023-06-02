using SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Solution.Entities;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys;

public class AccountTypeAnalisy
{
    public AccountTypeAnalisy(CreateAccountSolutionInput input, AccountEntity accountEntity)
    {
        Input = input;
        AccountEntity = accountEntity;
    }

    public CreateAccountSolutionInput Input { get; }
    public AccountEntity AccountEntity { get; }
}