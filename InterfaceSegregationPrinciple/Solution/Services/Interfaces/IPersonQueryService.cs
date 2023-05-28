using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Solution.Entities;
using SOLID.InterfaceSegregationPrinciple.Solution.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

public interface IPersonQueryService
{
    bool IsLegalPerson(CreateAccountInput input);
    PhysicalPersonEntity Get(CpfValueObject cpf);
    LegalPersonEntity Get(CnpjValueObject cnpj);
}