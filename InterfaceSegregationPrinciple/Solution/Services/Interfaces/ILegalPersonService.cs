using Api.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

public interface ILegalPersonService
{
    bool Create(LegalPersonEntity legalPerson);
}