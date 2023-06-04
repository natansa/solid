using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.DependencyInversionPrinciple.Solution.Services.Interfaces;

public interface IPersonService
{
    bool Create(CreateAccountIspSolutionInput input);
}