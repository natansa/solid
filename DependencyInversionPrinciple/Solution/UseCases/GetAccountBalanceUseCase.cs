using Api.DependencyInversionPrinciple.Solution.Boundaries.GetAccountBalance;
using Api.DependencyInversionPrinciple.Solution.Mappers;
using Api.DependencyInversionPrinciple.Solution.Repository;
using Api.DependencyInversionPrinciple.Solution.Services;
using Api.DependencyInversionPrinciple.Solution.Services.Interfaces;
using Api.DependencyInversionPrinciple.Solution.UseCases.Interfaces;

namespace Api.DependencyInversionPrinciple.Solution.UseCases;

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