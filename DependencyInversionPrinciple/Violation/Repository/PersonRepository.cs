using SOLID.DependencyInversionPrinciple.Violation.Entities;

namespace SOLID.DependencyInversionPrinciple.Violation.Repository;

public class PersonRepository
{
    public bool PersonAlreadyExists(PersonEntity personEntity)
    {
        return false;
    }
}