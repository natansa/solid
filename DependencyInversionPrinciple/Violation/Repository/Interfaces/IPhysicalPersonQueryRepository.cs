using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository.Interfaces;

public interface IPhysicalPersonQueryRepository
{
    bool PhysicalPersonAlreadyExists(PhysicalPersonEntity physicalPerson);
}
