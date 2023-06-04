using Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;

namespace Api.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IAccountTypeAnalisysService
{
    void Dispatcher(AccountTypeAnalisy accountTypeAnalisy);
}
