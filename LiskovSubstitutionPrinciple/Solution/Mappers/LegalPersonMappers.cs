using Api.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using Api.LiskovSubstitutionPrinciple.Solution.Entities;

namespace Api.LiskovSubstitutionPrinciple.Solution.Mappers;

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