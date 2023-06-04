using Api.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys.Strategy;
using Api.InterfaceSegregationPrinciple.Solution.UseCases.Interfaces;
using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Solution.Mappers;
using SOLID.InterfaceSegregationPrinciple.Solution.Repository;
using SOLID.InterfaceSegregationPrinciple.Solution.Services;
using SOLID.InterfaceSegregationPrinciple.Solution.Services.AccountTypeAnalisys;

namespace SOLID.InterfaceSegregationPrinciple.Solution.UseCases;

public class CreateAccountUseCase : ICreateAccountUseCase
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

            return successCreatedAccount.AccountEntity.MapToOuuput();
        }
        
        return default;
    }
}