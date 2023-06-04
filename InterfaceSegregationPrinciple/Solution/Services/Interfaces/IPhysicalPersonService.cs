using SOLID.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

public interface IPhysicalPersonService
{
    bool Create(PhysicalPersonEntity physicalPerson);
}