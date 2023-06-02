using SOLID.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.OpenClosedPrinciple.Solution.Entities;

namespace SOLID.OpenClosedPrinciple.Solution.Mappers;

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