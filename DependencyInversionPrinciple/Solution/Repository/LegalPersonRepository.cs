using Api.DependencyInversionPrinciple.Solution.Repository.Interfaces;
using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository;

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