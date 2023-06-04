using Api.InterfaceSegregationPrinciple.Violation.Entities;

namespace Api.InterfaceSegregationPrinciple.Violation.Repository;

public class LegalPersonRepository
{
    public bool LegalPersonAlreadyExists(LegalPersonEntity legalPersonEntity)
    {
        return false;
    }

    public int CreateNewLegalPerson(LegalPersonEntity legalPersonEntity)
    {
        var rowAffecteds = 1;
        return rowAffecteds;
    }
}