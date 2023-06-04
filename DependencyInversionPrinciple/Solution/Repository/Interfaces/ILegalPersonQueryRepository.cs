using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface ILegalPersonQueryRepository
    {
        bool LegalPersonAlreadyExists(LegalPersonEntity legalPersonEntity);
    }
}
