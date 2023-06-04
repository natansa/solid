namespace SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;

public class CreateAccountIspViolationOutput
{
    public CreateAccountIspViolationOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}