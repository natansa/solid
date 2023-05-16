using SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Solution.Mappers;
using SOLID.LiskovSubstitutionPrinciple.Solution.Repository;
using SOLID.LiskovSubstitutionPrinciple.Solution.Services;
using SOLID.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.UseCases;

public class CreateAccountUseCase
{
    private readonly PersonService _personService;
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

        _personService = new PersonService(new PersonRepository(), new PhysicalPersonRepository(), new LegalPersonRepository());
        _accountService = new AccountService(new AccountRepository());
    }

    public CreateAccountOutput Create(CreateAccountInput input)
    {
        var successCreatedPerson = CreatePerson(input);
        var successCreatedAccount = _accountService.Create(input.MapToAccountEntity());

        if (successCreatedPerson && successCreatedAccount.Success)
        {
            _accountTypeAnalisysService.Dispatcher(successCreatedAccount.AccountEntity.MapToAnalisy(input));
            return successCreatedAccount.AccountEntity.MapToOutput();
        }
        
        return default;
    }

    private bool CreatePerson(CreateAccountInput input) 
    {
        if (_personService.IsLegalPerson(input))
        {
            return _personService.Create(input.MapToLegalPersonEntity());
        }
            
        return _personService.Create(input.MapToPhysicalPersonEntity());
    }
}