namespace SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountSolutionOutput
{
    public CreateAccountSolutionOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}