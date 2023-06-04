using Api.LiskovSubstitutionPrinciple.Solution.Entities;

namespace Api.LiskovSubstitutionPrinciple.Solution.Repository;

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