using Api.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Violation.ValueObjects;

namespace Api.InterfaceSegregationPrinciple.Violation.Mappers;

public static class CnpjMappers
{
    public static CnpjValueObject MapToCnpj(this CreateAccountIspViolationInput input) 
    {
        return new CnpjValueObject(input.Document);
    }
}