using Api.DependencyInversionPrinciple.Solution.Services.Interfaces;
using Api.DependencyInversionPrinciple.Solution.Services.Interfaces.AccountTypeAnalisys;

namespace Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

public class AccountTypeAnalisysService : IAccountTypeAnalisysService
{
    private readonly IIndividualAccountHandler _individualAccountHandler;

    public AccountTypeAnalisysService(IIndividualAccountHandler individualAccountHandler)
    {
        _individualAccountHandler = individualAccountHandler;
    }

    public void Dispatcher(AccountTypeAnalisy accountTypeAnalisy) 
    {
        _individualAccountHandler.HandleRequest(accountTypeAnalisy);
    }
}
