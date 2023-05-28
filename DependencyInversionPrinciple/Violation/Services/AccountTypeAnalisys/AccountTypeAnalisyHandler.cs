namespace SOLID.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;

public abstract class AccountTypeAnalisyHandler
{
    protected AccountTypeAnalisyHandler _nextHandler;

    public void SetNextHandler(AccountTypeAnalisyHandler handler)
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