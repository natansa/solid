﻿using Api.OpenClosedPrinciple.Solution.Services;
using Api.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys.ChainsOfResposability;

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