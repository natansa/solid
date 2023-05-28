using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Solution.Entities;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Mappers;

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