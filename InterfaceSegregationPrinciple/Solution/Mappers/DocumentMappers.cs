using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Solution.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Mappers;

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