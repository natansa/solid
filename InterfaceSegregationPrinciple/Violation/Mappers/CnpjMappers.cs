using SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Violation.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Mappers;

public static class CnpjMappers
{
    public static CnpjValueObject MapToCnpj(this CreateAccountIspViolationInput input) 
    {
        return new CnpjValueObject(input.Document);
    }
}