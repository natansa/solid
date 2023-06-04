using Api.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

public interface IPersonService
{
    bool Create(CreateAccountIspSolutionInput input);
}