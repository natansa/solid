using SOLID.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Violation.Entities;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Mappers;

public static class PhysicalPersonMappers
{
    public static PhysicalPersonEntity MapToPhysicalPersonEntity(this CreateAccountInput input) 
    {
        return new PhysicalPersonEntity
        (
            name: input.Name,
            birthday: input.Birthday,
            cpf: input.MapToCpf(),
            phone: input.Phone
        );
    }

    public static LegalPersonEntity MapToLegalPersonEntity(this CreateAccountInput input)
    {
        return new LegalPersonEntity
        (
            name: input.Name,
            cnpj: input.MapToCnpj(),
            phone: input.Phone
        );
    }
}