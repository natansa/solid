using SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces;
using SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces.AccountTypeAnalisys;

namespace SOLID.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

public class IndividualAccountHandler : AccountTypeAnalisyHandler, IIndividualAccountHandler
{
    private readonly ISmsService _smsService;

    public IndividualAccountHandler(ISmsService smsService)
    {
        _smsService = smsService;
    }

    public override void HandleRequest(AccountTypeAnalisy accountTypeAnalisy)
    {
        if (accountTypeAnalisy.AccountEntity.IsIndividualAccount())
        {
            _smsService.Send(accountTypeAnalisy.Input.Phone);
            return;
        }
        
        _nextHandler?.HandleRequest(accountTypeAnalisy);
    }
}