using SOLID.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Solution.Entities;
using SOLID.DependencyInversionPrinciple.Solution.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces;

public interface IPersonService
{
    bool IsLegalPerson(CreateAccountInput input);
    bool Create(PhysicalPersonEntity physicalPerson);
    bool Create(LegalPersonEntity legalPerson);
    PhysicalPersonEntity Get(CpfValueObject cpf);
    LegalPersonEntity Get(CnpjValueObject cnpj);
}