using SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Solution.Entities;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class PhysicalPersonMappers
{
    public static PhysicalPersonEntity MapToPhysicalPersonEntity(this CreateAccountSolutionInput input) 
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