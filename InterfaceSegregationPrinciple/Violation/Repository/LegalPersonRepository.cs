using SOLID.InterfaceSegregationPrinciple.Violation.Entities;
using SOLID.InterfaceSegregationPrinciple.Violation.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Repository;

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