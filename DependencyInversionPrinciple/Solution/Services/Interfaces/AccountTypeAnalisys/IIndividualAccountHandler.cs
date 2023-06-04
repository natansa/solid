using Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.DependencyInversionPrinciple.Solution.Services.Interfaces.AccountTypeAnalisys
{
    public interface IIndividualAccountHandler
    {
        void HandleRequest(AccountTypeAnalisy accountTypeAnalisy);
    }
}