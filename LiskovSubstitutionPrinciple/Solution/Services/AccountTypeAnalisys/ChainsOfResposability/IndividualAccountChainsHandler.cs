﻿using SOLID.LiskovSubstitutionPrinciple.Solution.Services;
using SOLID.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys.ChainsOfResposability;

public class IndividualAccountChainsHandler : AccountTypeAnalisyChainsHandler
{
    private readonly SmsService _smsService;

    public IndividualAccountChainsHandler()
    {
        _smsService = new SmsService();
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