using SOLID.LiskovSubstitutionPrinciple.Violation.Entities;

namespace SOLID.LiskovSubstitutionPrinciple.Violation.Repository;

public class PhysicalPersonRepository
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