using Api.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Solution.ValueObjects;

namespace Api.InterfaceSegregationPrinciple.Solution.Mappers;

public static class CnpjMappers
{
    public static CnpjValueObject MapToCnpj(this CreateAccountIspSolutionInput input) 
    {
        return new CnpjValueObject(input.Document);
    }
}