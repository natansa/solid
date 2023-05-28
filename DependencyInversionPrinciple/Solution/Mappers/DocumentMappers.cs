using SOLID.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Solution.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Solution.Mappers;

public static class DocumentMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountInput input) 
    {
        return new CpfValueObject(input.Document);
    }

    public static CnpjValueObject MapToCnpj(this CreateAccountInput input)
    {
        return new CnpjValueObject(input.Document);
    }
}