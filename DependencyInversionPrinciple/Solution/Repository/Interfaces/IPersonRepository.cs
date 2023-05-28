using SOLID.DependencyInversionPrinciple.Solution.Entities;

namespace SOLID.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface IPersonRepository
    {
        bool PersonAlreadyExists(PersonEntity personEntity);
    }
}