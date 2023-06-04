using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.ValueObjects;

namespace Api.DependencyInversionPrinciple.Violation.Mappers;

public static class CnpjMappers
{
    public static CnpjValueObject MapToCnpj(this CreateAccountIspSolutionInput input) 
    {
        return new CnpjValueObject(input.Document);
    }
}