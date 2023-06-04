using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces
{
    public interface ILegalPersonCommandRepository
    {
        int CreateNewLegalPerson(LegalPersonEntity legalPersonEntity);
    }
}
