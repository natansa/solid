using SOLID.InterfaceSegregationPrinciple.Violation.Entities;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Repository;

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