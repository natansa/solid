using SOLID.DependencyInversionPrinciple.Violation.Entities;
using SOLID.DependencyInversionPrinciple.Violation.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Violation.Repository;

public class LegalPersonRepository
{
    public int CreateNewLegalPerson(LegalPersonEntity legalPersonEntity)
    {
        var rowAffecteds = 1;
        return rowAffecteds;
    }

    public LegalPersonEntity Get(CnpjValueObject cnpj)
    {
        return default;
    }
}