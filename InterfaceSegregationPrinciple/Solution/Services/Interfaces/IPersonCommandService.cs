using SOLID.InterfaceSegregationPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.InterfaceSegregationPrinciple.Solution.Entities;
using SOLID.InterfaceSegregationPrinciple.Solution.ValueObjects;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

public interface IPersonCommandService
{
    bool Create(PhysicalPersonEntity physicalPerson);
    bool Create(LegalPersonEntity legalPerson);
}