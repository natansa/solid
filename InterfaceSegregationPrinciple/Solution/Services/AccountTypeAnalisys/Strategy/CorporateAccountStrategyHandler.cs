﻿using Api.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.Strategy;

public class CorporateAccountStrategyHandler : AccountTypeAnalisyStrategyHandler
{
    private readonly IComplianceService _complianceService;

    public CorporateAccountStrategyHandler()
    {
        _complianceService = new ComplianceService();
    }

    public CorporateAccountStrategyHandler(AccountTypeAnalisy accountTypeAnalisy)
    {
        _complianceService = new ComplianceService();
        AccountTypeAnalisy = accountTypeAnalisy;
    }

    public override void HandleRequest(AccountTypeAnalisy accountTypeAnalisy)
    {
        if (accountTypeAnalisy.AccountEntity.IsCorporateAccount())
        {
            _complianceService.Send(accountTypeAnalisy.AccountEntity.AccountNumber);
            return;
        }
    }

    public override void HandleRequest()
    {
        if (AccountTypeAnalisy.AccountEntity.IsCorporateAccount())
        {
            _complianceService.Send(AccountTypeAnalisy.AccountEntity.AccountNumber);
            return;
        }
    }
}