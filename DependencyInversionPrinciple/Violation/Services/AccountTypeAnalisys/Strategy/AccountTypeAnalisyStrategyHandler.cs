using Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;

namespace Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys.Strategy
{
    public abstract class AccountTypeAnalisyStrategyHandler
    {
        public AccountTypeAnalisy AccountTypeAnalisy;

        public abstract void HandleRequest();

        public abstract void HandleRequest(AccountTypeAnalisy accountTypeAnalisy);
    }
}
