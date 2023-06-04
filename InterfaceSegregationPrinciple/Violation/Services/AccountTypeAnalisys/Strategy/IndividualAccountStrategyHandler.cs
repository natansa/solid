using SOLID.InterfaceSegregationPrinciple.Violation.Services;
using SOLID.InterfaceSegregationPrinciple.Violation.Services.AccountTypeAnalisys;

namespace Api.InterfaceSegregationPrinciple.Violation.Services.AccountTypeAnalisys.Strategy;

public class IndividualAccountStrategyHandler : AccountTypeAnalisyStrategyHandler
{
    private readonly SmsService _smsService;

    public IndividualAccountStrategyHandler()
    {
        _smsService = new SmsService();
    }

    public IndividualAccountStrategyHandler(AccountTypeAnalisy accountTypeAnalisy)
    {
        _smsService = new SmsService();
        AccountTypeAnalisy = accountTypeAnalisy;
    }

    public override void HandleRequest(AccountTypeAnalisy accountTypeAnalisy)
    {
        if (accountTypeAnalisy.AccountEntity.IsIndividualAccount())
        {
            _smsService.Send(accountTypeAnalisy.Input.Phone);
            return;
        }
    }

    public override void HandleRequest()
    {
        if (AccountTypeAnalisy.AccountEntity.IsIndividualAccount())
        {
            _smsService.Send(AccountTypeAnalisy.Input.Phone);
            return;
        }
    }
}