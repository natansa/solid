using Api.InterfaceSegregationPrinciple.Solution.Services.Interfaces;
using Api.InterfaceSegregationPrinciple.Solution.Entities;
using Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces;

namespace Api.InterfaceSegregationPrinciple.Solution.Services;

public class LegalPersonService : ILegalPersonService
{
    private readonly ILegalPersonRepository _repository;

    public LegalPersonService(ILegalPersonRepository repository)
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