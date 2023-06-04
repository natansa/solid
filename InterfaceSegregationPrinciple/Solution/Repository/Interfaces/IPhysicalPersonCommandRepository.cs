using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces;

public interface IPhysicalPersonCommandRepository
{
    int CreateNewPhysicalPerson(PhysicalPersonEntity physicalPerson);
}
