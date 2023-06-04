using SOLID.InterfaceSegregationPrinciple.Violation.Services;
using SOLID.InterfaceSegregationPrinciple.Violation.Services.AccountTypeAnalisys;

namespace Api.InterfaceSegregationPrinciple.Violation.Services.AccountTypeAnalisys.ChainsOfResposability;

public class CorporateAccountChainsHandler : AccountTypeAnalisyChainsHandler
{
    private readonly ComplianceService _complianceService;

    public CorporateAccountChainsHandler()
    {
        _complianceService = new ComplianceService();
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