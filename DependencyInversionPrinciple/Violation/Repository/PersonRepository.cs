using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository;

public class PersonRepository
{
    public bool PersonAlreadyExists(PersonEntity personEntity)
    {
        return false;
    }
}