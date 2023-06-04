using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Repository.Interfaces
{
    public interface ILegalPersonQueryRepository
    {
        bool LegalPersonAlreadyExists(LegalPersonEntity legalPersonEntity);
    }
}
