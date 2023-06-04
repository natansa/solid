﻿using Api.DependencyInversionPrinciple.Solution.Services.Interfaces.AccountTypeAnalisys;

namespace Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

public class InvestmentAccountHandler : AccountTypeAnalisyHandler, IInvestmentAccountHandler
{
    private readonly B3Service _b3Service;

    public InvestmentAccountHandler(B3Service b3Service)
    {
        _b3Service = b3Service;
    }

    public override void HandleRequest(AccountTypeAnalisy accountTypeAnalisy)
    {
        if (accountTypeAnalisy.AccountEntity.IsInvestmentAccount())
        {
            _b3Service.Send(accountTypeAnalisy.AccountEntity.AccountNumber);
            return;
        }
        
        _nextHandler?.HandleRequest(accountTypeAnalisy);
    }
}