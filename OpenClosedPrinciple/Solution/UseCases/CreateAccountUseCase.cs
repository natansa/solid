using Api.OpenClosedPrinciple.Solution.Services.AccountTypeAnalisys.Strategy;
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

    public CreateAccountOcpSolutionOutput Create(CreateAccountOcpSolutionInput input)
    {
        var successCreatedPhysicalPerson = _physicalPersonService.Create(input.MapToPhysicalPersonEntity());
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