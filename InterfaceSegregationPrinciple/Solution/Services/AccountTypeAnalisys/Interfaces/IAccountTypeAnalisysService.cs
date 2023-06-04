using Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.Strategy;
using Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.Interfaces;

public interface IAccountTypeAnalisysService
{
    void DispatcherChainsOfResponsability(AccountTypeAnalisy accountTypeAnalisy);
    void DispatcherStrategy(AccountTypeAnalisy accountTypeAnalisy);
    void DispatcherStrategy(AccountTypeAnalisyStrategyHandler strategy);
}