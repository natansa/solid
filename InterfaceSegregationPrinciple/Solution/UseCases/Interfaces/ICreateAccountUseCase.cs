using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.InterfaceSegregationPrinciple.Solution.UseCases.Interfaces;

public interface ICreateAccountUseCase
{
    CreateAccountIspSolutionOutput Create(CreateAccountIspSolutionInput input);
}