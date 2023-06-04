using Api.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using Api.OpenClosedPrinciple.Solution.Entities;

namespace Api.OpenClosedPrinciple.Solution.Mappers;

public static class PhysicalPersonMappers
{
    public static PhysicalPersonEntity MapToPhysicalPersonEntity(this CreateAccountOcpSolutionInput input) 
    {
        return new PhysicalPersonEntity
        (
            name: input.Name,
            birthday: input.Birthday,
            cpf: input.MapToValueObject(),
            phone: input.Phone
        );
    }
}