using Api.DependencyInversionPrinciple.Solution.Boundaries.GetAccountBalance;
using Api.DependencyInversionPrinciple.Solution.Mappers;
using Api.DependencyInversionPrinciple.Solution.Services.Interfaces;
using Api.DependencyInversionPrinciple.Solution.UseCases.Interfaces;

namespace Api.DependencyInversionPrinciple.Solution.UseCases;

public class GetAccountBalanceUseCase : IGetAccountBalanceUseCase
{
    private readonly IAccountService _accountService;

    public GetAccountBalanceUseCase(IAccountService accountService)
    {
        _accountService = accountService;
    }

    public GetAccountBalanceOutput GetAccountBalance(GetAccountBalanceInput input)
    {
        var accountEntity = _accountService.GetAccountBalance(input.MapToAccountEntity());
        return accountEntity.MapToOutputAccountBalance();
    }
}