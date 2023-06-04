namespace Api.DependencyInversionPrinciple.Solution.Boundaries.GetAccountBalance;

public class GetAccountBalanceOutput
{
    public GetAccountBalanceOutput(decimal accountBalance)
    {
        AccountBalance = accountBalance;
    }

    public decimal AccountBalance { get; }
}