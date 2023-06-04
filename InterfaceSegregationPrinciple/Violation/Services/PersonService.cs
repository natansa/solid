using SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Violation.Enums;
using SOLID.InterfaceSegregationPrinciple.Violation.Mappers;
using SOLID.InterfaceSegregationPrinciple.Violation.Repository;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Services;

public class PersonService
{
    private readonly PhysicalPersonService _physicalPersonService;
    private readonly LegalPersonService _legalPersonService;

    public PersonService()
    {
        _physicalPersonService = new PhysicalPersonService(new PhysicalPersonRepository());
        _legalPersonService = new LegalPersonService(new LegalPersonRepository());
    }

    public bool Create(CreateAccountIspViolationInput input) 
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
