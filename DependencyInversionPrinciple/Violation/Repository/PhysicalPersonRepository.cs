using SOLID.DependencyInversionPrinciple.Violation.Entities;
using SOLID.DependencyInversionPrinciple.Violation.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Violation.Repository;

public class PhysicalPersonRepository
{
    public int CreateNewPhysicalPerson(PhysicalPersonEntity physicalPerson)
    {
        var rowAffecteds = 1;
        return rowAffecteds;
    }

    public PhysicalPersonEntity Get(CpfValueObject cpf)
    {
        return default;
    }
}