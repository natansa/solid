using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository.Interfaces
{
    public interface ILegalPersonQueryRepository
    {
        bool LegalPersonAlreadyExists(LegalPersonEntity legalPersonEntity);
    }
}
