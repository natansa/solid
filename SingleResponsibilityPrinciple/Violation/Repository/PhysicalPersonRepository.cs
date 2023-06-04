namespace Api.SingleResponsibilityPrinciple.Violation.Repository;

public class PhysicalPersonRepository
{
    public bool PhysicalPersonAlreadyExists(string cpf)
    {
        return false;
    }

    public void CreateNewPhysicalPerson(string name, string cpf)
    {

    }
}