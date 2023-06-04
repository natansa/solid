using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Solution.ValueObjects;

namespace Api.DependencyInversionPrinciple.Solution.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountDipSolutionInput input) 
    {
        return new CpfValueObject(input.Document);
    }
}