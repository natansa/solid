using Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.DependencyInversionPrinciple.Solution.Services.Interfaces.AccountTypeAnalisys
{
    public interface ICorporateAccountHandler
    {
        void HandleRequest(AccountTypeAnalisy accountTypeAnalisy);
    }
}