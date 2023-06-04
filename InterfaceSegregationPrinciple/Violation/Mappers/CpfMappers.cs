using Api.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Violation.ValueObjects;

namespace Api.InterfaceSegregationPrinciple.Violation.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountIspViolationInput input) 
    {
        return new CpfValueObject(input.Document);
    }
}