using SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Solution.ValueObjects;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToValueObject(this CreateAccountSolutionInput input) 
    {
        return new CpfValueObject(input.Cpf);
    }
}