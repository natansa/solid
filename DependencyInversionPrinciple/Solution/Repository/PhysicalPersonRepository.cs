using SOLID.DependencyInversionPrinciple.Solution.Entities;
using SOLID.DependencyInversionPrinciple.Solution.Repository.Interfaces;
using SOLID.DependencyInversionPrinciple.Solution.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Solution.Repository;

public class PhysicalPersonRepository : IPhysicalPersonRepository
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