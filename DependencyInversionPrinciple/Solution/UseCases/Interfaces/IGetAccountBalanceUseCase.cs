using Api.DependencyInversionPrinciple.Solution.Boundaries.GetAccountBalance;

namespace Api.DependencyInversionPrinciple.Solution.UseCases.Interfaces;

public interface IGetAccountBalanceUseCase
{
    GetAccountBalanceOutput GetAccountBalance(GetAccountBalanceInput input);
}