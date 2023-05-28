using SOLID.DependencyInversionPrinciple.Solution.Entities;
using SOLID.DependencyInversionPrinciple.Solution.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface IPhysicalPersonRepository
    {
        int CreateNewPhysicalPerson(PhysicalPersonEntity physicalPerson);
        PhysicalPersonEntity Get(CpfValueObject cpf);
    }
}