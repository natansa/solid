using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces;

public interface IPhysicalPersonCommandRepository
{
    int CreateNewPhysicalPerson(PhysicalPersonEntity physicalPerson);
}
