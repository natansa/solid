using SOLID.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Violation.Entities;
using SOLID.DependencyInversionPrinciple.Violation.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IPersonQueryService
{
    bool IsLegalPerson(CreateAccountInput input);
    PhysicalPersonEntity Get(CpfValueObject cpf);
    LegalPersonEntity Get(CnpjValueObject cnpj);
}