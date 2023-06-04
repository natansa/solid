using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces;

public interface IPhysicalPersonRepository
{
    bool PhysicalPersonAlreadyExists(PhysicalPersonEntity physicalPerson);
    int CreateNewPhysicalPerson(PhysicalPersonEntity physicalPerson);
}
