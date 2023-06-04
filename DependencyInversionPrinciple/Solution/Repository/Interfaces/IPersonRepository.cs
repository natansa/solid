using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface IPersonRepository
    {
        bool PersonAlreadyExists(PersonEntity personEntity);
    }
}