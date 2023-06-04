using Api.DependencyInversionPrinciple.Solution.Services.Interfaces;
using Api.DependencyInversionPrinciple.Solution.Entities;
using Api.DependencyInversionPrinciple.Solution.Repository.Interfaces;

namespace Api.DependencyInversionPrinciple.Solution.Services;

public class PhysicalPersonService : IPhysicalPersonService
{
    private readonly IPhysicalPersonQueryRepository _queryRepository;
    private readonly IPhysicalPersonCommandRepository _commandRepository;

    public PhysicalPersonService(IPhysicalPersonQueryRepository queryRepository, 
                                 IPhysicalPersonCommandRepository commandRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public bool Create(PhysicalPersonEntity physicalPerson)
    {
        Validate(physicalPerson);
        var rowAffecteds = _commandRepository.CreateNewPhysicalPerson(physicalPerson);
        var success = rowAffecteds > 0;
        return success;
    }

    private void Validate(PhysicalPersonEntity physicalPerson) 
    {
        if (physicalPerson == null) throw new ArgumentNullException(nameof(PhysicalPersonEntity));
        
        if (physicalPerson.IsInvalid()) throw new InvalidOperationException(nameof(physicalPerson));

        if (PhysicalPersonAlreadyExists(physicalPerson)) throw new InvalidOperationException($"Pessoa {physicalPerson.Cpf} ja existe");
    }

    private bool PhysicalPersonAlreadyExists(PhysicalPersonEntity physicalPerson)
    {
        var physicalPersonAlreadyExists = _queryRepository.PhysicalPersonAlreadyExists(physicalPerson);
        return physicalPersonAlreadyExists;
    }
}