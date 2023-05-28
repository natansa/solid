using SOLID.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Violation.Entities;

namespace SOLID.DependencyInversionPrinciple.Violation.Mappers;

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