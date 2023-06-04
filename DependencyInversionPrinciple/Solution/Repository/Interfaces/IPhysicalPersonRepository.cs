using Api.DependencyInversionPrinciple.Solution.Entities;
using Api.DependencyInversionPrinciple.Solution.ValueObjects;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface IPhysicalPersonRepository
    {
        int CreateNewPhysicalPerson(PhysicalPersonEntity physicalPerson);
        PhysicalPersonEntity Get(CpfValueObject cpf);
    }
}