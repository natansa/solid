using Microsoft.AspNetCore.Mvc;
using ViolationUseCases = Api.OpenClosedPrinciple.Violation.UseCases;
using ViolationInput = Api.OpenClosedPrinciple.Violation.Boundaries.CreateAccount;
using SolutionUseCases = Api.OpenClosedPrinciple.Solution.UseCases;
using SolutionInput = Api.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OcpController : ControllerBase
{
    private readonly ViolationUseCases.CreateAccountUseCase _createAccountUseCaseViolation;
    private readonly SolutionUseCases.CreateAccountUseCase _createAccountUseCaseSolution;

    public OcpController()
    {
        _createAccountUseCaseViolation = new ViolationUseCases.CreateAccountUseCase();
        _createAccountUseCaseSolution = new SolutionUseCases.CreateAccountUseCase();
    }

    [HttpPost("Violation")]
    public void CreateAccountViolation(ViolationInput.CreateAccountOcpViolationInput createAccountInput)
    {
        _createAccountUseCaseViolation.Create(createAccountInput);
    }

    [HttpPost("Solution")]
    public void CreateAccountSolution(SolutionInput.CreateAccountOcpSolutionInput createAccountInput)
    {
        _createAccountUseCaseSolution.Create(createAccountInput);
    }
}