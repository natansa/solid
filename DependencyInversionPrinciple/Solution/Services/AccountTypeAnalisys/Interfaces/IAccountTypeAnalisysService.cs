using Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys.Strategy;
using Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys.Interfaces;

public interface IAccountTypeAnalisysService
{
    void DispatcherChainsOfResponsability(AccountTypeAnalisy accountTypeAnalisy);
    void DispatcherStrategy(AccountTypeAnalisy accountTypeAnalisy);
    void DispatcherStrategy(AccountTypeAnalisyStrategyHandler strategy);
}