using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository.Interfaces;

public interface IPhysicalPersonCommandRepository
{
    int CreateNewPhysicalPerson(PhysicalPersonEntity physicalPerson);
}
