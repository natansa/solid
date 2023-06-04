namespace SOLID.InterfaceSegregationPrinciple.Solution.Entities;

public abstract class PersonEntity
{
    protected PersonEntity(string name, string phone, int token)
    {
        Name = name;
        Phone = phone;
        Token = token;
    }

    protected string Name { get; set; }
    protected string Phone { get; set; }
    protected int Token { get; set; }

    public abstract bool IsInvalid();

    public abstract bool TokenIsValid();
}