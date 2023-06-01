using Api.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys.ChainsOfResposability;

namespace SOLID.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

public class AccountTypeAnalisysService
{
    private readonly SmsService _smsService;
    private readonly ComplianceService _complianceService;
    private readonly B3Service _b3Service;
    private readonly IndividualAccountChainsHandler _individualAccountHandler;
    private readonly CorporateAccountChainsHandler _corporateAccountHandler;
    private readonly InvestmentAccountChainsHandler _investmentAccountHandler;

    public AccountTypeAnalisysService(SmsService smsService, ComplianceService complianceService, B3Service b3Service)
    {
        _smsService = smsService;
        _complianceService = complianceService;
        _b3Service = b3Service;

        _individualAccountHandler = new IndividualAccountChainsHandler(_smsService);
        _corporateAccountHandler = new CorporateAccountChainsHandler(_complianceService);
        _investmentAccountHandler = new InvestmentAccountChainsHandler(_b3Service);

        _individualAccountHandler.SetNextHandler(_corporateAccountHandler);
        _corporateAccountHandler.SetNextHandler(_investmentAccountHandler);
    }

    public void DispatcherChainsOfResponsability(AccountTypeAnalisy accountTypeAnalisy) 
    {
        _individualAccountHandler.HandleRequest(accountTypeAnalisy);
    }

    public void DispatcherStrategy(AccountTypeAnalisy accountTypeAnalisy)
    {
        _individualAccountHandler.HandleRequest(accountTypeAnalisy);
    }
}
