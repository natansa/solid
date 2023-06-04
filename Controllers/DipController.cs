using Microsoft.AspNetCore.Mvc;
using ViolationUseCases = Api.DependencyInversionPrinciple.Violation.UseCases;
using ViolationInput = Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using SolutionUseCases = Api.DependencyInversionPrinciple.Solution.UseCases;
using SolutionInput = Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DipController : ControllerBase
{
    private readonly ViolationUseCases.CreateAccountUseCase _createAccountUseCaseViolation;
    private readonly SolutionUseCases.Interfaces.ICreateAccountUseCase _createAccountUseCaseSolution;

    public DipController(SolutionUseCases.Interfaces.ICreateAccountUseCase createAccountUseCaseSolution)
    {
        _createAccountUseCaseViolation = new ViolationUseCases.CreateAccountUseCase();
        _createAccountUseCaseSolution = createAccountUseCaseSolution;
    }

    [HttpPost("Violation")]
    public void CreateAccountViolation(ViolationInput.CreateAccountDipViolationInput createAccountInput)
    {
        _createAccountUseCaseViolation.Create(createAccountInput);
    }

    [HttpPost("Solution")]
    public void CreateAccountSolution(SolutionInput.CreateAccountDipSolutionInput createAccountInput)
    {
        _createAccountUseCaseSolution.Create(createAccountInput);
    }
}