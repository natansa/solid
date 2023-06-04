using Api.DependencyInversionPrinciple.Solution.Entities;

namespace Api.DependencyInversionPrinciple.Solution.Services.Interfaces;

public interface ILegalPersonService
{
    bool Create(LegalPersonEntity legalPerson);
}