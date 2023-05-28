using SOLID.DependencyInversionPrinciple.Violation.Boundaries.CreateAccount;
using SOLID.DependencyInversionPrinciple.Violation.Entities;
using SOLID.DependencyInversionPrinciple.Violation.ValueObjects;

namespace SOLID.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface IPersonCommandService
{
    bool Create(PhysicalPersonEntity physicalPerson);
    bool Create(LegalPersonEntity legalPerson);
}