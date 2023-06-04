using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.DependencyInversionPrinciple.Solution.UseCases.Interfaces;

public interface ICreateAccountUseCase
{
    CreateAccountIspSolutionOutput Create(CreateAccountIspSolutionInput input);
}