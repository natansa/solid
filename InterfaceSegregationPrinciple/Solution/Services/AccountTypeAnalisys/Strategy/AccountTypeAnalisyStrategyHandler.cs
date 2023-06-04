using SOLID.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.Strategy
{
    public abstract class AccountTypeAnalisyStrategyHandler
    {
        public AccountTypeAnalisy AccountTypeAnalisy;

        public abstract void HandleRequest();

        public abstract void HandleRequest(AccountTypeAnalisy accountTypeAnalisy);
    }
}
