using Api.InterfaceSegregationPrinciple.Solution.Services.Interfaces;
using Api.InterfaceSegregationPrinciple.Solution.Entities;
using Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces;

namespace Api.InterfaceSegregationPrinciple.Solution.Services;

public class PhysicalPersonService : IPhysicalPersonService
{
    private readonly IPhysicalPersonRepository _repository;

    public PhysicalPersonService(IPhysicalPersonRepository repository)
    {
        _repository = repository;
    }

    public bool Create(PhysicalPersonEntity physicalPerson)
    {
        Validate(physicalPerson);
        var rowAffecteds = _repository.CreateNewPhysicalPerson(physicalPerson);
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
        var physicalPersonAlreadyExists = _repository.PhysicalPersonAlreadyExists(physicalPerson);
        return physicalPersonAlreadyExists;
    }
}