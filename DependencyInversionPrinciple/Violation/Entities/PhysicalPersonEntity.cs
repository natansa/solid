using Api.DependencyInversionPrinciple.Violation.ValueObjects;

namespace Api.DependencyInversionPrinciple.Violation.Entities;

public class PhysicalPersonEntity : PersonEntity
{
    public PhysicalPersonEntity(string name, DateTime birthday, CpfValueObject cpf, string phone, int token)
        : base(name, phone, token)
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

    public override bool TokenIsValid()
    {
        if (Token > 0) return true;
        return false;
    }

    private bool IsMinorAge()
    {
        return DateTime.Now.Year - Birthday.Year < 18;
    }
}