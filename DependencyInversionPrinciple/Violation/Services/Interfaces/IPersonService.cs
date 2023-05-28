using SOLID.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Violation.Entities;
using SOLID.DependencyInversionPrinciple.Violation.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IPersonService
{
    bool IsLegalPerson(CreateAccountInput input);
    bool Create(PhysicalPersonEntity physicalPerson);
    bool Create(LegalPersonEntity legalPerson);
    PhysicalPersonEntity Get(CpfValueObject cpf);
    LegalPersonEntity Get(CnpjValueObject cnpj);
}