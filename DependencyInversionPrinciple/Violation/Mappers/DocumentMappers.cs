using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.ValueObjects;

namespace Api.DependencyInversionPrinciple.Violation.Mappers;

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