﻿using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.ValueObjects;

namespace Api.DependencyInversionPrinciple.Violation.Mappers;

public static class CpfMappers
{
    public static CpfValueObject MapToCpf(this CreateAccountDipViolationInput input) 
    {
        return new CpfValueObject(input.Document);
    }
}