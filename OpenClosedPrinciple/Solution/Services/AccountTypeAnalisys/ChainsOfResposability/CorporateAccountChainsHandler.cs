using SOLID.OpenClosedPrinciple.Solution.Services;
using SOLID.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys.ChainsOfResposability;

public class CorporateAccountHandler : AccountTypeAnalisyHandler
{
    private readonly ComplianceService _complianceService;

    public CorporateAccountHandler(ComplianceService complianceService)
    {
        _complianceService = complianceService;
    }

    public override void HandleRequest(AccountTypeAnalisy accountTypeAnalisy)
    {
        if (accountTypeAnalisy.AccountEntity.IsCorporateAccount())
        {
            _complianceService.Send(accountTypeAnalisy.AccountEntity.AccountNumber);
            return;
        }

        _nextHandler?.HandleRequest(accountTypeAnalisy);
    }
}