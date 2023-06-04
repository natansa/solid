using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Services.Interfaces;

public interface IPhysicalPersonService
{
    bool Create(PhysicalPersonEntity physicalPerson);
}