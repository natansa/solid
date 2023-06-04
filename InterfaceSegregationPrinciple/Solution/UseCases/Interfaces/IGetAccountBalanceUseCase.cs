using Api.InterfaceSegregationPrinciple.Solution.Boundaries.GetAccountBalance;

namespace Api.InterfaceSegregationPrinciple.Solution.UseCases.Interfaces;

public interface IGetAccountBalanceUseCase
{
    GetAccountBalanceOutput GetAccountBalance(GetAccountBalanceInput input);
}