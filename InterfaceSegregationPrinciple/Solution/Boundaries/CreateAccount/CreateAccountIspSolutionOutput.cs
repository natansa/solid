namespace Api.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountIspSolutionOutput
{
    public CreateAccountIspSolutionOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}