using Api.InterfaceSegregationPrinciple.Solution.Services;
using Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.ChainsOfResposability;

public class InvestmentAccountChainsHandler : AccountTypeAnalisyChainsHandler
{
    private readonly B3Service _b3Service;

    public InvestmentAccountChainsHandler()
    {
        _b3Service = new B3Service();
    }

    public override void HandleRequest(AccountTypeAnalisy accountTypeAnalisy)
    {
        if (accountTypeAnalisy.AccountEntity.IsInvestmentAccount())
        {
            _b3Service.Send(accountTypeAnalisy.AccountEntity.AccountNumber);
            return;
        }

        _nextHandler?.HandleRequest(accountTypeAnalisy);
    }
}