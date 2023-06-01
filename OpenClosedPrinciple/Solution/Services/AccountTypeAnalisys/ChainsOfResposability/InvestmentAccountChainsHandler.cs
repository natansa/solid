﻿using SOLID.OpenClosedPrinciple.Solution.Services;
using SOLID.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys.ChainsOfResposability;

public class InvestmentAccountChainsHandler : AccountTypeAnalisyChainsHandler
{
    private readonly B3Service _b3Service;

    public InvestmentAccountChainsHandler(B3Service b3Service)
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