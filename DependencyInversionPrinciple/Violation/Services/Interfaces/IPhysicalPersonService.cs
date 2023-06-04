using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IPhysicalPersonService
{
    bool Create(PhysicalPersonEntity physicalPerson);
}