namespace SOLID.SingleResponsibilityPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountSrpSolutionOutput
{
    public CreateAccountSrpSolutionOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}