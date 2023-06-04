using Api.DependencyInversionPrinciple.Violation.Repository.Interfaces;
using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository;

public class PhysicalPersonRepository : IPhysicalPersonQueryRepository, IPhysicalPersonCommandRepository
{
    public bool PhysicalPersonAlreadyExists(PhysicalPersonEntity physicalPerson)
    {
        return false;
    }

    public int CreateNewPhysicalPerson(PhysicalPersonEntity physicalPerson)
    {
        var rowAffecteds = 1;
        return rowAffecteds;
    }
}