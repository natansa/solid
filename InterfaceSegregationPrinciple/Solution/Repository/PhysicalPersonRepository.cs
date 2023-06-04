using Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces;
using SOLID.InterfaceSegregationPrinciple.Solution.Entities;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Repository;

public class PhysicalPersonRepository : IPhysicalPersonRepository
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