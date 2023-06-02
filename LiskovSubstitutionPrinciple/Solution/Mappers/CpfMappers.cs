﻿using SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.LiskovSubstitutionPrinciple.Solution.ValueObjects;

namespace SOLID.LiskovSubstitutionPrinciple.Solution.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountLspSolutionInput input) 
    {
        return new CpfValueObject(input.Document);
    }
}