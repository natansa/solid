using SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Violation.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountIspViolationInput input) 
    {
        return new CpfValueObject(input.Document);
    }
}