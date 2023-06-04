using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces
{
    public interface ILegalPersonRepository
    {
        bool LegalPersonAlreadyExists(LegalPersonEntity legalPersonEntity);
        int CreateNewLegalPerson(LegalPersonEntity legalPersonEntity);
    }
}
