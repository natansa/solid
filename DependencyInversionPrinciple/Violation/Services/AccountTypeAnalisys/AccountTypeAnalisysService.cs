using SOLID.DependencyInversionPrinciple.Violation.Services.Interfaces;

namespace SOLID.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;

public class AccountTypeAnalisysService : IAccountTypeAnalisysService
{
    private readonly SmsService _smsService;
    private readonly ComplianceService _complianceService;
    private readonly B3Service _b3Service;
    private readonly IndividualAccountHandler _individualAccountHandler;
    private readonly CorporateAccountHandler _corporateAccountHandler;
    private readonly InvestmentAccountHandler _investmentAccountHandler;

    public AccountTypeAnalisysService(SmsService smsService, ComplianceService complianceService, B3Service b3Service)
    {
        _smsService = smsService;
        _complianceService = complianceService;
        _b3Service = b3Service;

        _individualAccountHandler = new IndividualAccountHandler(_smsService);
        _corporateAccountHandler = new CorporateAccountHandler(_complianceService);
        _investmentAccountHandler = new InvestmentAccountHandler(_b3Service);

        _individualAccountHandler.SetNextHandler(_corporateAccountHandler);
        _corporateAccountHandler.SetNextHandler(_investmentAccountHandler);
    }

    public void Dispatcher(AccountTypeAnalisy accountTypeAnalisy) 
    {
        _individualAccountHandler.HandleRequest(accountTypeAnalisy);
    }
}
