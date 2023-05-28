﻿using SOLID.DependencyInversionPrinciple.Violation.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Violation.Entities;

public class LegalPersonEntity : PersonEntity
{
    public LegalPersonEntity(string name, CnpjValueObject cnpj, string phone)
        : base(name, phone)
    {
        Cnpj = cnpj;
    }

    public CnpjValueObject Cnpj { get; private set; }

    public override bool IsInvalid()
    {
        if (Cnpj.IsInvalid()) return true;

        return false;
    }
}