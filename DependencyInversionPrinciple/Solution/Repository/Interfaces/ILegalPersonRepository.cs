using SOLID.DependencyInversionPrinciple.Solution.Entities;
using SOLID.DependencyInversionPrinciple.Solution.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Solution.Repository.Interfaces
{
    public interface ILegalPersonRepository
    {
        int CreateNewLegalPerson(LegalPersonEntity legalPersonEntity);
        LegalPersonEntity Get(CnpjValueObject cnpj);
    }
}