using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Solution.ValueObjects;

namespace Api.DependencyInversionPrinciple.Solution.Mappers;

public static class CnpjMappers
{
    public static CnpjValueObject MapToCnpj(this CreateAccountDipSolutionInput input) 
    {
        return new CnpjValueObject(input.Document);
    }
}