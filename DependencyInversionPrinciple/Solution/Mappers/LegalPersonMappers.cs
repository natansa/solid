using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Mappers;

public static class LegalPersonMappers
{
    public static LegalPersonEntity MapToLegalPersonEntity(this CreateAccountIspSolutionInput input) 
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