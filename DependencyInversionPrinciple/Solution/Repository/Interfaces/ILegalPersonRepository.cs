using Api.DependencyInversionPrinciple.Solution.Entities;
using Api.DependencyInversionPrinciple.Solution.ValueObjects;

namespace Api.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface ILegalPersonRepository
    {
        int CreateNewLegalPerson(LegalPersonEntity legalPersonEntity);
        LegalPersonEntity Get(CnpjValueObject cnpj);
    }
}