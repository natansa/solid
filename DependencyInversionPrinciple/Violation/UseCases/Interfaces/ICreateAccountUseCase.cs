using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;

namespace Api.DependencyInversionPrinciple.Violation.UseCases.Interfaces;

public interface ICreateAccountUseCase
{
    CreateAccountIspSolutionOutput Create(CreateAccountIspSolutionInput input);
}