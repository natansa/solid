namespace Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;

public class CreateAccountDipViolationOutput
{
    public CreateAccountDipViolationOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}