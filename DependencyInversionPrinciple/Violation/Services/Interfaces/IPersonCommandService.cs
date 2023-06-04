using Api.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using Api.DependencyInversionPrinciple.Violation.Entities;
using Api.DependencyInversionPrinciple.Violation.ValueObjects;

namespace Api.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IPersonCommandService
{
    bool Create(PhysicalPersonEntity physicalPerson);
    bool Create(LegalPersonEntity legalPerson);
}