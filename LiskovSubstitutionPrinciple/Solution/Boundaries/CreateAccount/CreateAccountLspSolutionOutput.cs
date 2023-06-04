namespace Api.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountLspSolutionOutput
{
    public CreateAccountLspSolutionOutput(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public string AccountNumber { get; }
}