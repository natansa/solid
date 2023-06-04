﻿using SOLID.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.ChainsOfResposability;

public abstract class AccountTypeAnalisyChainsHandler
{
    protected AccountTypeAnalisyChainsHandler _nextHandler;

    public void SetNextHandler(AccountTypeAnalisyChainsHandler handler)
    {
        _nextHandler = handler;
    }

    public virtual void HandleRequest(AccountTypeAnalisy accountTypeAnalisy)
    {
        if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(accountTypeAnalisy);
        }
    }
}