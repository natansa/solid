using Microsoft.AspNetCore.Mvc;
using ViolationUseCases = Api.InterfaceSegregationPrinciple.Violation.UseCases;
using ViolationInput = Api.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using SolutionUseCases = Api.InterfaceSegregationPrinciple.Solution.UseCases;
using SolutionInput = Api.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IspController : ControllerBase
    {
        private readonly ViolationUseCases.CreateAccountUseCase _createAccountUseCaseViolation;
        private readonly SolutionUseCases.Interfaces.ICreateAccountUseCase _createAccountUseCaseSolution;

        public IspController()
        {
            _createAccountUseCaseViolation = new ViolationUseCases.CreateAccountUseCase();
            _createAccountUseCaseSolution = new SolutionUseCases.CreateAccountUseCase();
        }

        [HttpPost("Violation")]
        public void CreateAccountViolation(ViolationInput.CreateAccountIspViolationInput createAccountInput)
        {
            _createAccountUseCaseViolation.Create(createAccountInput);
        }

        [HttpPost("Solution")]
        public void CreateAccountSolution(SolutionInput.CreateAccountIspSolutionInput createAccountInput)
        {
            _createAccountUseCaseSolution.Create(createAccountInput);
        }
    }
}