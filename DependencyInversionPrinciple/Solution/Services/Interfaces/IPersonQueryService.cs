using SOLID.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Solution.Entities;
using SOLID.DependencyInversionPrinciple.Solution.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces;

public interface IPersonQueryService
{
    bool IsLegalPerson(CreateAccountInput input);
    PhysicalPersonEntity Get(CpfValueObject cpf);
    LegalPersonEntity Get(CnpjValueObject cnpj);
}