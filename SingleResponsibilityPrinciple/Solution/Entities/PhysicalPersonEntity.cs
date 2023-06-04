using Api.SingleResponsibilityPrinciple.Solution.ValueObjects;

namespace Api.SingleResponsibilityPrinciple.Solution.Entities;

public class PhysicalPersonEntity
{
    public PhysicalPersonEntity(string name, DateTime birthday, CpfValueObject cpf, string phone)
    {
        Name = name;
        Birthday = birthday;
        Cpf = cpf;
        Phone = phone;
    }

    public string Name { get; private set; }
    public DateTime Birthday { get; private set; }
    public CpfValueObject Cpf { get; private set; }
    public string Phone { get; set; }

    public bool IsInvalid()
    {
        if (Cpf.IsInvalid()) return true;

        if (IsMinorAge()) return true;

        return false;
    }

    private bool IsMinorAge()
    {
        return DateTime.Now.Year - Birthday.Year < 18;
    }
}