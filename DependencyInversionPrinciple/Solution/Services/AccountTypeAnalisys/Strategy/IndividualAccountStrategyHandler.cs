using Api.DependencyInversionPrinciple.Solution.Services.Interfaces;

namespace Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys.Strategy;

public class IndividualAccountStrategyHandler : AccountTypeAnalisyStrategyHandler
{
    private readonly ISmsService _smsService;

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