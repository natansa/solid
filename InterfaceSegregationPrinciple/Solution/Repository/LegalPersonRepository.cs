using Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces;
using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Repository;

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