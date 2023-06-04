using Api.DependencyInversionPrinciple.Violation.Boundaries.GetAccountBalance;
using Api.DependencyInversionPrinciple.Violation.Mappers;
using Api.DependencyInversionPrinciple.Violation.Repository;
using Api.DependencyInversionPrinciple.Violation.Services;
using Api.DependencyInversionPrinciple.Violation.Services.Interfaces;
using Api.DependencyInversionPrinciple.Violation.UseCases.Interfaces;

namespace Api.DependencyInversionPrinciple.Violation.UseCases;

public class GetAccountBalanceUseCase : IGetAccountBalanceUseCase
{
    private readonly IAccountService _accountService;

    public GetAccountBalanceUseCase()
    {
        _accountService = new AccountService(new AccountRepository(), new AccountRepository());
    }

    public GetAccountBalanceOutput GetAccountBalance(GetAccountBalanceInput input)
    {
        var accountEntity = _accountService.GetAccountBalance(input.MapToAccountEntity());
        return accountEntity.MapToOutputAccountBalance();
    }
}