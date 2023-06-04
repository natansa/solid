using Api.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Solution.ValueObjects;

namespace Api.InterfaceSegregationPrinciple.Solution.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountIspSolutionInput input) 
    {
        return new CpfValueObject(input.Document);
    }
}