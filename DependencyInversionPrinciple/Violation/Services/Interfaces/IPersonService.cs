using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;

namespace Api.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IPersonService
{
    bool Create(CreateAccountIspSolutionInput input);
}