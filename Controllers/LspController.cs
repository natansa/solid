using Microsoft.AspNetCore.Mvc;
using SolutionUseCases = Api.LiskovSubstitutionPrinciple.Solution.UseCases;
using SolutionInput = Api.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LspController : ControllerBase
{
    private readonly SolutionUseCases.CreateAccountUseCase _createAccountUseCaseSolution;

    public LspController()
    {
        _createAccountUseCaseSolution = new SolutionUseCases.CreateAccountUseCase();
    }

    [HttpPost("Solution")]
    public void CreateAccountSolution(SolutionInput.CreateAccountLspSolutionInput createAccountInput)
    {
        _createAccountUseCaseSolution.Create(createAccountInput);
    }
}