using SOLID.LiskovSubstitutionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Violation.Entities;

namespace SOLID.LiskovSubstitutionPrinciple.Violation.Services.AccountTypeAnalisys;

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