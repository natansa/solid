using Api.InterfaceSegregationPrinciple.Violation.Services.AccountTypeAnalisys.Strategy;
using Api.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Violation.Mappers;
using Api.InterfaceSegregationPrinciple.Violation.Repository;
using Api.InterfaceSegregationPrinciple.Violation.Services;
using Api.InterfaceSegregationPrinciple.Violation.Services.AccountTypeAnalisys;
using SOLID.InterfaceSegregationPrinciple.Violation.Mappers;

namespace Api.InterfaceSegregationPrinciple.Violation.UseCases;

public class CreateAccountUseCase
{
    private readonly AccountService _accountService;
    private readonly AccountTypeAnalisysService _accountTypeAnalisysService;
    private readonly PersonService _personService;

    public CreateAccountUseCase()
    {
        _accountTypeAnalisysService = new AccountTypeAnalisysService
        (
            new SmsService(), 
            new ComplianceService(), 
            new B3Service()
        );

        _personService = new PersonService();
        _accountService = new AccountService(new AccountRepository());
    }

    public CreateAccountIspViolationOutput Create(CreateAccountIspViolationInput input)
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

            return successCreatedAccount.AccountEntity.MapToOuuput();
        }
        
        return default;
    }
}