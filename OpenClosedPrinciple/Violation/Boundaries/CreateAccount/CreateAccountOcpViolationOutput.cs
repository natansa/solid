namespace Api.OpenClosedPrinciple.Violation.Boundaries.CreateAccount;

public class CreateAccountOcpViolationOutput
{
    public CreateAccountOcpViolationOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}