using Api.DependencyInversionPrinciple.Solution.Services.Interfaces;
using Api.DependencyInversionPrinciple.Solution.Entities;
using Api.DependencyInversionPrinciple.Solution.Repository.Interfaces;

namespace Api.DependencyInversionPrinciple.Solution.Services;

public class LegalPersonService : ILegalPersonService
{
    private readonly ILegalPersonQueryRepository _queryRepository;
    private readonly ILegalPersonCommandRepository _commandRepository;

    public LegalPersonService(ILegalPersonQueryRepository queryRepository, 
                              ILegalPersonCommandRepository commandRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public bool Create(LegalPersonEntity legalPerson)
    {
        Validate(legalPerson);
        var rowAffecteds = _commandRepository.CreateNewLegalPerson(legalPerson);
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
        var physicalPersonAlreadyExists = _queryRepository.LegalPersonAlreadyExists(legalPerson);
        return physicalPersonAlreadyExists;
    }
}