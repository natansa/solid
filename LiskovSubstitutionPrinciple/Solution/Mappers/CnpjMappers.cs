using SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Solution.ValueObjects;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class CnpjMappers
{
    public static CnpjValueObject MapToCnpj(this CreateAccountLspSolutionInput input) 
    {
        return new CnpjValueObject(input.Document);
    }
}