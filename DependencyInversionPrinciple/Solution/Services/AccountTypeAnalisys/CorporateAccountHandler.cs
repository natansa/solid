﻿using SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces;
using SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces.AccountTypeAnalisys;

namespace SOLID.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

public class CorporateAccountHandler : AccountTypeAnalisyHandler, ICorporateAccountHandler
{
    private readonly IComplianceService _complianceService;

    public CorporateAccountHandler(IComplianceService complianceService)
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