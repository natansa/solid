using SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.OpenClosedPrinciple.Solution.ValueObjects;

namespace SOLID.OpenClosedPrinciple.Solution.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToValueObject(this CreateAccountInput input) 
    {
        return new CpfValueObject(input.Cpf);
    }
}