using SOLID.InterfaceSegregationPrinciple.Violation.Entities;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Repository;

public class PersonRepository
{
    public bool PersonAlreadyExists(PersonEntity personEntity)
    {
        return false;
    }
}