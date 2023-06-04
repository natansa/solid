using Api.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;
using Api.InterfaceSegregationPrinciple.Violation.Entities;

namespace Api.InterfaceSegregationPrinciple.Violation.Mappers;

public static class PhysicalPersonMappers
{
    public static PhysicalPersonEntity MapToPhysicalPersonEntity(this CreateAccountIspViolationInput input) 
    {
        return new PhysicalPersonEntity
        (
            name: input.Name,
            birthday: input.Birthday,
            cpf: input.MapToCpf(),
            phone: input.Phone,
            token: input.Token
        );
    }
}