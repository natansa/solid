using SOLID.InterfaceSegregationPrinciple.Solution.Entities;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Repository;

public class PersonRepository
{
    public bool PersonAlreadyExists(PersonEntity personEntity)
    {
        return false;
    }
}