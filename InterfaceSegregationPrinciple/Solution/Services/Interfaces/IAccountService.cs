using Api.InterfaceSegregationPrinciple.Solution.Models;
using SOLID.InterfaceSegregationPrinciple.Solution.Entities;

namespace Api.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

public interface IAccountService
{
    CreateAccountResult Create(AccountEntity account);
}
