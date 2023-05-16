namespace SOLID.LiskovSubstitutionPrinciple.Violation.Services.AccountTypeAnalisys;

public class IndividualAccountHandler : AccountTypeAnalisyHandler
{
    private readonly SmsService _smsService;

    public IndividualAccountHandler(SmsService smsService)
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