using SOLID.DependencyInversionPrinciple.Solution.Entities;
using SOLID.DependencyInversionPrinciple.Solution.Repository.Interfaces;

namespace SOLID.DependencyInversionPrinciple.Solution.Repository;

public class PersonRepository : IPersonRepository
{
    public bool PersonAlreadyExists(PersonEntity personEntity)
    {
        return false;
    }
}