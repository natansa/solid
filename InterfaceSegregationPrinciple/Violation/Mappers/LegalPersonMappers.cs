using Api.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Violation.Entities;

namespace Api.InterfaceSegregationPrinciple.Violation.Mappers;

public static class LegalPersonMappers
{
    public static LegalPersonEntity MapToLegalPersonEntity(this CreateAccountIspViolationInput input) 
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