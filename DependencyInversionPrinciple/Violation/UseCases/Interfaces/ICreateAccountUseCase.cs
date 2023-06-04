using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;

namespace Api.DependencyInversionPrinciple.Violation.UseCases.Interfaces;

public interface ICreateAccountUseCase
{
    CreateAccountDipViolationOutput Create(CreateAccountDipViolationInput input);
}