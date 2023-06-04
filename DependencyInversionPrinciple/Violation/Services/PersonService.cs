using Api.DependencyInversionPrinciple.Violation.Services.Interfaces;
using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.Enums;
using Api.DependencyInversionPrinciple.Violation.Mappers;
using Api.DependencyInversionPrinciple.Violation.Repository;

namespace Api.DependencyInversionPrinciple.Violation.Services;

public class PersonService : IPersonService
{
    private readonly PhysicalPersonService _physicalPersonService;
    private readonly LegalPersonService _legalPersonService;

    public PersonService()
    {
        _physicalPersonService = new PhysicalPersonService(new PhysicalPersonRepository(), new PhysicalPersonRepository());
        _legalPersonService = new LegalPersonService(new LegalPersonRepository(), new LegalPersonRepository());
    }

    public bool Create(CreateAccountDipViolationInput input) 
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
