namespace SOLID.InterfaceSegregationPrinciple.Violation.Entities;

public abstract class PersonEntity
{
    protected PersonEntity(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }

    public string Name { get; set; }
    public string Phone { get; set; }

    public abstract bool IsInvalid();
}