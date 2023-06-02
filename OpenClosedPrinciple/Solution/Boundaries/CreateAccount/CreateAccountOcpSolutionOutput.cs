namespace SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountOcpSolutionOutput
{
    public CreateAccountOcpSolutionOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}