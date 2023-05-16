using SOLID.LiskovSubstitutionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Violation.ValueObjects;

namespace SOLID.LiskovSubstitutionPrinciple.Violation.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToValueObject(this CreateAccountInput input) 
    {
        return new CpfValueObject(input.Cpf);
    }
}