using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Solution.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountIspSolutionInput input) 
    {
        return new CpfValueObject(input.Document);
    }
}