using SOLID.LiskovSubstitutionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Violation.Mappers;
using SOLID.LiskovSubstitutionPrinciple.Violation.Repository;
using SOLID.LiskovSubstitutionPrinciple.Violation.Services;
using SOLID.LiskovSubstitutionPrinciple.Violation.Services.AccountTypeAnalisys;

namespace SOLID.LiskovSubstitutionPrinciple.Violation.UseCases;

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

    public CreateAccountOutput Create(CreateAccountInput input)
    {
        var successCreatedPhysicalPerson = _physicalPersonService.Create(input.MapToPhysicalPersonEntity());
        var successCreatedAccount = _accountService.Create(input.MapToAccountEntity());

        if (successCreatedPhysicalPerson && successCreatedAccount.Success)
        {
            _accountTypeAnalisysService.Dispatcher(successCreatedAccount.AccountEntity.MapToAnalisy(input));

            return successCreatedAccount.AccountEntity.MapToOuuput();
        }
        
        return default;
    }
}