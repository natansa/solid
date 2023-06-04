using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Solution.Mappers;
using Api.DependencyInversionPrinciple.Solution.Services.Interfaces;
using Api.DependencyInversionPrinciple.Solution.UseCases.Interfaces;

namespace Api.DependencyInversionPrinciple.Solution.UseCases;

public class CreateAccountUseCase : ICreateAccountUseCase
{
    private readonly IPersonService _personService;
    private readonly IPersonQueryService _personQueryService;
    private readonly IPersonCommandService _personCommandService;
    private readonly IAccountService _accountService;
    private readonly IAccountTypeAnalisysService _accountTypeAnalisysService;

    public CreateAccountUseCase(IPersonService personService, 
                                IPersonQueryService personQueryService, 
                                IPersonCommandService personCommandService, 
                                IAccountService accountService, 
                                IAccountTypeAnalisysService accountTypeAnalisysService)
    {
        _personService = personService;
        _personQueryService = personQueryService;
        _personCommandService = personCommandService;
        _accountService = accountService;
        _accountTypeAnalisysService = accountTypeAnalisysService;
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