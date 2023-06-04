using Api.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using Api.LiskovSubstitutionPrinciple.Solution.ValueObjects;

namespace Api.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountLspSolutionInput input) 
    {
        return new CpfValueObject(input.Document);
    }
}