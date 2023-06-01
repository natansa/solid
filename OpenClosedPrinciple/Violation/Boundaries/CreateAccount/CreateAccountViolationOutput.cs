namespace SOLID.OpenClosedPrinciple.Violation.Boundaries.CreateAccount;

public class CreateAccountViolationOutput
{
    public CreateAccountViolationOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}