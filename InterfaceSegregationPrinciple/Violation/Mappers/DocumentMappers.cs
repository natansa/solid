using SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Violation.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Mappers;

public static class DocumentMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountInput input) 
    {
        return new CpfValueObject(input.Document);
    }

    public static CnpjValueObject MapToCnpj(this CreateAccountInput input)
    {
        return new CnpjValueObject(input.Document);
    }
}