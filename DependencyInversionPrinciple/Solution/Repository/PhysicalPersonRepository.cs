using Api.DependencyInversionPrinciple.Solution.Repository.Interfaces;
using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository;

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