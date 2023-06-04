using Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys.Strategy;
using Api.DependencyInversionPrinciple.Violation.UseCases.Interfaces;
using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.Mappers;
using Api.DependencyInversionPrinciple.Violation.Repository;
using Api.DependencyInversionPrinciple.Violation.Services;
using Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys;
using Api.DependencyInversionPrinciple.Violation.Services.Interfaces;
using Api.DependencyInversionPrinciple.Violation.Services.AccountTypeAnalisys.Interfaces;

namespace Api.DependencyInversionPrinciple.Violation.UseCases;

public class CreateAccountUseCase : ICreateAccountUseCase
{
    private readonly IAccountService _accountService;
    private readonly IAccountTypeAnalisysService _accountTypeAnalisysService;
    private readonly IPersonService _personService;

    public CreateAccountUseCase()
    {
        _accountTypeAnalisysService = new AccountTypeAnalisysService();
        _personService = new PersonService();
        _accountService = new AccountService(new AccountRepository(), new AccountRepository());
    }

    public CreateAccountIspSolutionOutput Create(CreateAccountIspSolutionInput input)
    {
        var successCreatedPhysicalPerson = _personService.Create(input);
        var successCreatedAccount = _accountService.Create(input.MapToAccountEntity());

        if (successCreatedPhysicalPerson && successCreatedAccount.Success)
        {
            // OPEN CLOSED WITH CHAIS OF RESPNSABILITY
            _accountTypeAnalisysService.DispatcherChainsOfResponsability(successCreatedAccount.AccountEntity.MapToAnalisy(input));

            // OPEN CLOSED WITH STRATEGY - MODEL ONE
            _accountTypeAnalisysService.DispatcherStrategy(successCreatedAccount.AccountEntity.MapToAnalisy(input));

            // OPEN CLOSED WITH STRATEGY - MODEL TWO
            switch (successCreatedAccount.AccountEntity.AccountType)
            {
                case Enums.AccountType.IndividualAccount:
                    _accountTypeAnalisysService.DispatcherStrategy(new IndividualAccountStrategyHandler(successCreatedAccount.AccountEntity.MapToAnalisy(input)));
                    break;
                case Enums.AccountType.CorporateAccount:
                    _accountTypeAnalisysService.DispatcherStrategy(new CorporateAccountStrategyHandler(successCreatedAccount.AccountEntity.MapToAnalisy(input)));
                    break;
                case Enums.AccountType.InvestmentAccount:
                    _accountTypeAnalisysService.DispatcherStrategy(new InvestmentAccountStrategyHandler(successCreatedAccount.AccountEntity.MapToAnalisy(input)));
                    break;
                default:
                    throw new InvalidOperationException($"Erro in {nameof(successCreatedAccount.AccountEntity.AccountType)}");
                    break;
            }

            return successCreatedAccount.AccountEntity.MapToOutput();
        }
        
        return default;
    }
}