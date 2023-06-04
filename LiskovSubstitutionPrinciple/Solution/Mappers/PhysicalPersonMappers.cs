using Api.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using Api.LiskovSubstitutionPrinciple.Solution.Entities;

namespace Api.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class PhysicalPersonMappers
{
    public static PhysicalPersonEntity MapToPhysicalPersonEntity(this CreateAccountLspSolutionInput input) 
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