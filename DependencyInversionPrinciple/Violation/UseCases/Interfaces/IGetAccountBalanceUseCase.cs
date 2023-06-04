using Api.DependencyInversionPrinciple.Violation.Boundaries.GetAccountBalance;

namespace Api.DependencyInversionPrinciple.Violation.UseCases.Interfaces;

public interface IGetAccountBalanceUseCase
{
    GetAccountBalanceOutput GetAccountBalance(GetAccountBalanceInput input);
}