using Api.DependencyInversionPrinciple.Solution.Entities;
using Api.DependencyInversionPrinciple.Solution.Repository.Interfaces;

namespace Api.DependencyInversionPrinciple.Solution.Repository;

public class PersonRepository : IPersonRepository
{
    public bool PersonAlreadyExists(PersonEntity personEntity)
    {
        return false;
    }
}