using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository.Interfaces
{
    public interface ILegalPersonCommandRepository
    {
        int CreateNewLegalPerson(LegalPersonEntity legalPersonEntity);
    }
}
