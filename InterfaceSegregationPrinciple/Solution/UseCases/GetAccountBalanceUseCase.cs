using Api.InterfaceSegregationPrinciple.Solution.Boundaries.GetAccountBalance;
using Api.InterfaceSegregationPrinciple.Solution.Mappers;
using Api.InterfaceSegregationPrinciple.Solution.Repository;
using Api.InterfaceSegregationPrinciple.Solution.Services;
using Api.InterfaceSegregationPrinciple.Solution.Services.Interfaces;
using Api.InterfaceSegregationPrinciple.Solution.UseCases.Interfaces;

namespace Api.InterfaceSegregationPrinciple.Solution.UseCases;

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