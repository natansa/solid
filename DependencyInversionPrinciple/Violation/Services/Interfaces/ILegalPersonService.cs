using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface ILegalPersonService
{
    bool Create(LegalPersonEntity legalPerson);
}