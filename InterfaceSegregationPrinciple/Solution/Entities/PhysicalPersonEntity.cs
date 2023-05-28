using SOLID.InterfaceSegregationPrinciple.Solution.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Entities;

public class PhysicalPersonEntity : PersonEntity
{
    public PhysicalPersonEntity(string name, DateTime birthday, CpfValueObject cpf, string phone) 
        : base (name, phone)
    {
        Birthday = birthday;
        Cpf = cpf;
    }

    public DateTime Birthday { get; private set; }
    public CpfValueObject Cpf { get; private set; }

    public override bool IsInvalid()
    {
        if (Cpf.IsInvalid()) return true;

        if (IsMinorAge()) return true;

        return false;
    }

    private bool IsMinorAge()
    {
        return DateTime.Now.Year - Birthday.Year > 18;
    }
}