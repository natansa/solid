using Api.InterfaceSegregationPrinciple.Violation.Boundaries.GetAccountBalance;
using Api.InterfaceSegregationPrinciple.Violation.Repository;
using Api.InterfaceSegregationPrinciple.Violation.Services;
using Api.InterfaceSegregationPrinciple.Violation.Mappers;

namespace Api.InterfaceSegregationPrinciple.Violation.UseCases;

public class GetAccountBalanceUseCase
{
    private readonly AccountService _accountService;

    public GetAccountBalanceUseCase()
    {
        _accountService = new AccountService(new AccountRepository());
    }

    public GetAccountBalanceOutput GetAccountBalance(GetAccountBalanceInput input)
    {
        var accountEntity = _accountService.GetAccountBalance(input.MapToAccountEntity());
        return accountEntity.MapToOutputAccountBalance();
    }
}