using SOLID.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

namespace SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces.AccountTypeAnalisys
{
    public interface IInvestmentAccountHandler
    {
        void HandleRequest(AccountTypeAnalisy accountTypeAnalisy);
    }
}