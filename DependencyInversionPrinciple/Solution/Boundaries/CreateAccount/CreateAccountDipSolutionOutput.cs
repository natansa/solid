namespace Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountDipSolutionOutput
{
    public CreateAccountDipSolutionOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}