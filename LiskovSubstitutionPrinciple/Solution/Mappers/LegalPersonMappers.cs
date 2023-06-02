using SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Solution.Entities;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class LegalPersonMappers
{
    public static LegalPersonEntity MapToLegalPersonEntity(this CreateAccountLspSolutionInput input) 
    {
        return new LegalPersonEntity
        (
            name: input.Name,
            cnpj: input.MapToCnpj(),
            phone: input.Phone,
            token: input.Token
        );
    }
}