using Microsoft.AspNetCore.Mvc;
using ViolationUseCases = SOLID.OpenClosedPrinciple.Violation.UseCases;
using ViolationInput = SOLID.OpenClosedPrinciple.Violation.Boundaries.CreateAccount;
using SolutionUseCases = SOLID.OpenClosedPrinciple.Solution.UseCases;
using SolutionInput = SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.Controllers
{
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
        public void CreateAccountViolation(ViolationInput.CreateAccountViolationInput createAccountInput)
        {
            _createAccountUseCaseViolation.Create(createAccountInput);
        }

        [HttpPost("Solution")]
        public void CreateAccountSolution(SolutionInput.CreateAccountSolutionInput createAccountInput)
        {
            _createAccountUseCaseSolution.Create(createAccountInput);
        }
    }
}