using Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys.Strategy;
using Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;

namespace Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys.Interfaces;

public interface IAccountTypeAnalisysService
{
    void DispatcherChainsOfResponsability(AccountTypeAnalisy accountTypeAnalisy);
    void DispatcherStrategy(AccountTypeAnalisy accountTypeAnalisy);
    void DispatcherStrategy(AccountTypeAnalisyStrategyHandler strategy);
}