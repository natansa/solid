using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Mappers;

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