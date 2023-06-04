using Api.InterfaceSegregationPrinciple.Violation.Entities;
using Api.InterfaceSegregationPrinciple.Violation.Repository;

namespace Api.InterfaceSegregationPrinciple.Violation.Services;

public class LegalPersonService
{
    private readonly LegalPersonRepository _repository;

    public LegalPersonService(LegalPersonRepository repository)
    {
        _repository = repository;
    }

    public bool Create(LegalPersonEntity legalPerson)
    {
        Validate(legalPerson);
        var rowAffecteds = _repository.CreateNewLegalPerson(legalPerson);
        var success = rowAffecteds > 0;
        return success;
    }

    private void Validate(LegalPersonEntity legalPerson) 
    {
        if (legalPerson == null) throw new ArgumentNullException(nameof(PhysicalPersonEntity));
        
        if (legalPerson.IsInvalid()) throw new InvalidOperationException(nameof(legalPerson));

        if (LegalPersonAlreadyExists(legalPerson)) throw new InvalidOperationException($"Pessoa {legalPerson.Cnpj} ja existe");
    }

    private bool LegalPersonAlreadyExists(LegalPersonEntity legalPerson)
    {
        var physicalPersonAlreadyExists = _repository.LegalPersonAlreadyExists(legalPerson);
        return physicalPersonAlreadyExists;
    }
}