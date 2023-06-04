using Api.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using Api.OpenClosedPrinciple.Solution.ValueObjects;

namespace Api.OpenClosedPrinciple.Solution.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToValueObject(this CreateAccountOcpSolutionInput input) 
    {
        return new CpfValueObject(input.Cpf);
    }
}