using Api.DependencyInversionPrinciple.Violation.Repository.Interfaces;
using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository;

public class LegalPersonRepository : ILegalPersonQueryRepository, ILegalPersonCommandRepository
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