using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Solution.Entities;
using SOLID.InterfaceSegregationPrinciple.Solution.Enums;
using SOLID.InterfaceSegregationPrinciple.Solution.Repository;
using SOLID.InterfaceSegregationPrinciple.Solution.Services.Interfaces;
using SOLID.InterfaceSegregationPrinciple.Solution.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Services;

public class PersonService : IPersonService, IPersonQueryService, IPersonCommandService
{
    private readonly PersonRepository _personRepository;
    private readonly PhysicalPersonRepository _physicalPersonRepository;
    private readonly LegalPersonRepository _legalPersonRepository;

    public PersonService(PersonRepository personRepository, PhysicalPersonRepository physicalPersonRepository, LegalPersonRepository legalPersonRepository)
    {
        _personRepository = personRepository;
        _physicalPersonRepository = physicalPersonRepository;
        _legalPersonRepository = legalPersonRepository;
    }

    public bool IsLegalPerson(CreateAccountInput input) 
    {
        if (input.AccountType == (int)AccountType.CorporateAccount)
        {
            return true;
        }

        return false;
    }

    public bool Create(PhysicalPersonEntity physicalPerson)
    {
        Validate(physicalPerson);
        var rowAffecteds = _physicalPersonRepository.CreateNewPhysicalPerson(physicalPerson);
        var success = rowAffecteds > 0;
        return success;
    }

    public bool Create(LegalPersonEntity legalPerson)
    {
        Validate(legalPerson);
        var rowAffecteds = _legalPersonRepository.CreateNewLegalPerson(legalPerson);
        var success = rowAffecteds > 0;
        return success;
    }

    public PhysicalPersonEntity Get(CpfValueObject cpf)
    {
        return _physicalPersonRepository.Get(cpf);
    }

    public LegalPersonEntity Get(CnpjValueObject cnpj)
    {
        return _legalPersonRepository.Get(cnpj);
    }

    private void Validate(PersonEntity personEntity)
    {
        if (personEntity == null) throw new ArgumentNullException(nameof(PersonEntity));

        if (personEntity.IsInvalid()) throw new InvalidOperationException(nameof(personEntity));

        if (PersonAlreadyExists(personEntity)) throw new InvalidOperationException($"Pessoa {personEntity.Name} ja existe");
    }

    private bool PersonAlreadyExists(PersonEntity personEntity)
    {
        var physicalPersonAlreadyExists = _personRepository.PersonAlreadyExists(personEntity);
        return physicalPersonAlreadyExists;
    }
}