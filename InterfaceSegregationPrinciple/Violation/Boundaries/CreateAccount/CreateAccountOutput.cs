namespace SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;

public class CreateAccountOutput
{
    public CreateAccountOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}