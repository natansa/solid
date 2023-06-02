using Microsoft.AspNetCore.Mvc;
using ViolationServices = SOLID.SingleResponsibilityPrinciple.Violation.Services;
using ViolationEntities = SOLID.SingleResponsibilityPrinciple.Violation.Entities;
using SolutionUseCases = SOLID.SingleResponsibilityPrinciple.Solution.UseCases;
using SolutionInput = SOLID.SingleResponsibilityPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SrpController : ControllerBase
    {
        private readonly ViolationServices.AccountService _accountServiceViolation;
        private readonly SolutionUseCases.CreateAccountUseCase _createAccountUseCase;

        public SrpController()
        {
            _accountServiceViolation = new ViolationServices.AccountService();
            _createAccountUseCase = new SolutionUseCases.CreateAccountUseCase();
        }

        [HttpPost("Violation")]
        public void CreateAccountViolation(ViolationEntities.PhysicalPersonEntity physicalPersonEntity)
        {
            _accountServiceViolation.CreateAccount(physicalPersonEntity);
        }

        [HttpPost("Solution")]
        public void CreateAccountSolution(SolutionInput.CreateAccountSrpSolutionInput createAccountInput)
        {
            _createAccountUseCase.Create(createAccountInput);
        }
    }
}