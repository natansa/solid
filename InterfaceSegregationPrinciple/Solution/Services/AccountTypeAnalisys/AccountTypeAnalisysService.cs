using Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.ChainsOfResposability;
using Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.Interfaces;
using Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.Strategy;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys;

public class AccountTypeAnalisysService : IAccountTypeAnalisysService
{
    private readonly IndividualAccountChainsHandler _individualAccountHandler;
    private readonly CorporateAccountChainsHandler _corporateAccountHandler;
    private readonly InvestmentAccountChainsHandler _investmentAccountHandler;
    private readonly ICollection<AccountTypeAnalisyStrategyHandler> _accountTypeAnalisyStrategyHandler;

    public AccountTypeAnalisysService()
    {
        _individualAccountHandler = new IndividualAccountChainsHandler();
        _corporateAccountHandler = new CorporateAccountChainsHandler();
        _investmentAccountHandler = new InvestmentAccountChainsHandler();

        _individualAccountHandler.SetNextHandler(_corporateAccountHandler);
        _corporateAccountHandler.SetNextHandler(_investmentAccountHandler);

        _accountTypeAnalisyStrategyHandler = new List<AccountTypeAnalisyStrategyHandler>();
        _accountTypeAnalisyStrategyHandler.Add(new CorporateAccountStrategyHandler());
        _accountTypeAnalisyStrategyHandler.Add(new IndividualAccountStrategyHandler());
        _accountTypeAnalisyStrategyHandler.Add(new InvestmentAccountStrategyHandler());
    }

    public void DispatcherChainsOfResponsability(AccountTypeAnalisy accountTypeAnalisy) 
    {
        _individualAccountHandler.HandleRequest(accountTypeAnalisy);
    }

    public void DispatcherStrategy(AccountTypeAnalisy accountTypeAnalisy)
    {
        foreach (var strategy in _accountTypeAnalisyStrategyHandler)
        {
            strategy.HandleRequest(accountTypeAnalisy);
        }
    }

    public void DispatcherStrategy(AccountTypeAnalisyStrategyHandler strategy)
    {
        strategy.HandleRequest();
    }
}
