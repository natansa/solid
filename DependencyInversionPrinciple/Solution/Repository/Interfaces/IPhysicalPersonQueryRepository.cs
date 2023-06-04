using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces;

public interface IPhysicalPersonQueryRepository
{
    bool PhysicalPersonAlreadyExists(PhysicalPersonEntity physicalPerson);
}
