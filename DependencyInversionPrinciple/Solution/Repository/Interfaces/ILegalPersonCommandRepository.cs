using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface ILegalPersonCommandRepository
    {
        int CreateNewLegalPerson(LegalPersonEntity legalPersonEntity);
    }
}
