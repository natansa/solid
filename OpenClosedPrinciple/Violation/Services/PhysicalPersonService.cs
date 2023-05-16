using SOLID.OpenClosedPrinciple.Violation.Entities;
using SOLID.OpenClosedPrinciple.Violation.Repository;

namespace SOLID.OpenClosedPrinciple.Violation.Services;

public class PhysicalPersonService
{
    private readonly PhysicalPersonRepository _repository;

    public PhysicalPersonService(PhysicalPersonRepository repository)
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