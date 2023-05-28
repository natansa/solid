using SOLID.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Violation.Mappers;
using SOLID.DependencyInversionPrinciple.Violation.Repository;
using SOLID.DependencyInversionPrinciple.Violation.Services;
using SOLID.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;
using SOLID.DependencyInversionPrinciple.Violation.Services.Interfaces;

namespace SOLID.DependencyInversionPrinciple.Violation.UseCases;

public class CreateAccountUseCase
{
    private readonly IPersonService _personService;
    private readonly IPersonQueryService _personQueryService;
    private readonly IPersonCommandService _personCommandService;
    private readonly IAccountService _accountService;
    private readonly IAccountTypeAnalisysService _accountTypeAnalisysService;

    public CreateAccountUseCase()
    {
        _accountTypeAnalisysService = new AccountTypeAnalisysService
        (
            new SmsService(), 
            new ComplianceService(), 
            new B3Service()
        );

        _personService = new PersonService(new PersonRepository(), new PhysicalPersonRepository(), new LegalPersonRepository());
        _personQueryService = new PersonService(new PersonRepository(), new PhysicalPersonRepository(), new LegalPersonRepository());
        _personCommandService = new PersonService(new PersonRepository(), new PhysicalPersonRepository(), new LegalPersonRepository());
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

    //private bool CreatePerson(CreateAccountInput input) 
    //{
    //    if (_personService.IsLegalPerson(input))
    //    {
    //        return _personService.Create(input.MapToLegalPersonEntity());
    //    }
            
    //    return _personService.Create(input.MapToPhysicalPersonEntity());
    //}

    private bool CreatePerson(CreateAccountInput input)
    {
        if (_personQueryService.IsLegalPerson(input))
        {
            return _personCommandService.Create(input.MapToLegalPersonEntity());
        }

        return _personCommandService.Create(input.MapToPhysicalPersonEntity());
    }
}