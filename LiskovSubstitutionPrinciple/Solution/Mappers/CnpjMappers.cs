using Api.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using Api.LiskovSubstitutionPrinciple.Solution.ValueObjects;

namespace Api.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class CnpjMappers
{
    public static CnpjValueObject MapToCnpj(this CreateAccountLspSolutionInput input) 
    {
        return new CnpjValueObject(input.Document);
    }
}