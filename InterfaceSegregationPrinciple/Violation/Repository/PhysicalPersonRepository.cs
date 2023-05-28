using SOLID.InterfaceSegregationPrinciple.Violation.Entities;
using SOLID.InterfaceSegregationPrinciple.Violation.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Repository;

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