using Api.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys.ChainsOfResposability;
using Api.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys.Strategy;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys;

public class AccountTypeAnalisysService
{
    private readonly SmsService _smsService;
    private readonly ComplianceService _complianceService;
    private readonly B3Service _b3Service;
    private readonly IndividualAccountChainsHandler _individualAccountHandler;
    private readonly CorporateAccountChainsHandler _corporateAccountHandler;
    private readonly InvestmentAccountChainsHandler _investmentAccountHandler;
    private readonly ICollection<AccountTypeAnalisyStrategyHandler> _accountTypeAnalisyStrategyHandler;

    public AccountTypeAnalisysService(SmsService smsService, ComplianceService complianceService, B3Service b3Service)
    {
        _smsService = smsService;
        _complianceService = complianceService;
        _b3Service = b3Service;

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
