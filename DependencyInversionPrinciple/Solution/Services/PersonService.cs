using SOLID.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Solution.Entities;
using SOLID.DependencyInversionPrinciple.Solution.Enums;
using SOLID.DependencyInversionPrinciple.Solution.Repository.Interfaces;
using SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces;
using SOLID.DependencyInversionPrinciple.Solution.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Solution.Services;

public class PersonService : IPersonService, IPersonQueryService, IPersonCommandService
{
    private readonly IPersonRepository _personRepository;
    private readonly IPhysicalPersonRepository _physicalPersonRepository;
    private readonly ILegalPersonRepository _legalPersonRepository;

    public PersonService(IPersonRepository personRepository, 
                         IPhysicalPersonRepository physicalPersonRepository, 
                         ILegalPersonRepository legalPersonRepository)
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