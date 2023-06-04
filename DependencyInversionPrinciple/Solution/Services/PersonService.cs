using Api.DependencyInversionPrinciple.Solution.Services.Interfaces;
using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Solution.Enums;
using Api.DependencyInversionPrinciple.Solution.Mappers;

namespace Api.DependencyInversionPrinciple.Solution.Services;

public class PersonService : IPersonService
{
    private readonly IPhysicalPersonService _physicalPersonService;
    private readonly ILegalPersonService _legalPersonService;

    public PersonService(IPhysicalPersonService physicalPersonService, ILegalPersonService legalPersonService)
    {
        _physicalPersonService = physicalPersonService;
        _legalPersonService = legalPersonService;
    }

    public bool Create(CreateAccountDipSolutionInput input) 
    {
        Dictionary<AccountType, Func<bool>> personsService = new Dictionary<AccountType, Func<bool>>
        {
            { AccountType.IndividualAccount, () => _physicalPersonService.Create(input.MapToPhysicalPersonEntity()) },
            { AccountType.InvestmentAccount, () => _physicalPersonService.Create(input.MapToPhysicalPersonEntity()) },
            { AccountType.CorporateAccount, () => _legalPersonService.Create(input.MapToLegalPersonEntity()) }
        };

        var accountType = (AccountType)Enum.ToObject(typeof(AccountType), input.AccountType);

        if (personsService.TryGetValue(accountType, out Func<bool> person)) 
        {
            var success = person.Invoke();
            return success;
        }

        throw new InvalidOperationException("Tipo de conta inválida");
    }
}