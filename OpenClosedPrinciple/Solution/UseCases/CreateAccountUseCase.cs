using SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.OpenClosedPrinciple.Solution.Mappers;
using SOLID.OpenClosedPrinciple.Solution.Repository;
using SOLID.OpenClosedPrinciple.Solution.Services;
using SOLID.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys;

namespace SOLID.OpenClosedPrinciple.Solution.UseCases;

public class CreateAccountUseCase
{
    private readonly PhysicalPersonService _physicalPersonService;
    private readonly AccountService _accountService;
    private readonly AccountTypeAnalisysService _accountTypeAnalisysService;

    public CreateAccountUseCase()
    {
        _accountTypeAnalisysService = new AccountTypeAnalisysService
        (
            new SmsService(), 
            new ComplianceService(), 
            new B3Service()
        );

        _physicalPersonService = new PhysicalPersonService(new PhysicalPersonRepository());
        _accountService = new AccountService(new AccountRepository());
    }

    public CreateAccountSolutionOutput Create(CreateAccountSolutionInput input)
    {
        var successCreatedPhysicalPerson = _physicalPersonService.Create(input.MapToPhysicalPersonEntity());
        var successCreatedAccount = _accountService.Create(input.MapToAccountEntity());

        if (successCreatedPhysicalPerson && successCreatedAccount.Success)
        {
            _accountTypeAnalisysService.DispatcherChainsOfResponsability(successCreatedAccount.AccountEntity.MapToAnalisy(input));

            return successCreatedAccount.AccountEntity.MapToOuuput();
        }
        
        return default;
    }
}