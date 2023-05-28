using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Solution.Entities;
using SOLID.InterfaceSegregationPrinciple.Solution.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

public interface IPersonService
{
    bool IsLegalPerson(CreateAccountInput input);
    bool Create(PhysicalPersonEntity physicalPerson);
    bool Create(LegalPersonEntity legalPerson);
    PhysicalPersonEntity Get(CpfValueObject cpf);
    LegalPersonEntity Get(CnpjValueObject cnpj);
}