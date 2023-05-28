using SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Violation.Entities;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Services.AccountTypeAnalisys;

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