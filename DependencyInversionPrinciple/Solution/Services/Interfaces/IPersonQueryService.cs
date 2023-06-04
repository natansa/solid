using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Solution.Entities;
using Api.DependencyInversionPrinciple.Solution.ValueObjects;

namespace Api.DependencyInversionPrinciple.Solution.Services.Interfaces;

public interface IPersonQueryService
{
    bool IsLegalPerson(CreateAccountInput input);
    PhysicalPersonEntity Get(CpfValueObject cpf);
    LegalPersonEntity Get(CnpjValueObject cnpj);
}