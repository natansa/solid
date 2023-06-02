using SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Solution.Entities;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys;

public class AccountTypeAnalisy
{
    public AccountTypeAnalisy(CreateAccountLspSolutionInput input, AccountEntity accountEntity)
    {
        Input = input;
        AccountEntity = accountEntity;
    }

    public CreateAccountLspSolutionInput Input { get; }
    public AccountEntity AccountEntity { get; }
}