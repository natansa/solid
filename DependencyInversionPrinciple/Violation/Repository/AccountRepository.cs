using Api.DependencyInversionPrinciple.Violation.Repository.Interfaces;
using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Repository;

public class AccountRepository : IAccountCommandRepository, IAccountQueryRepository
{
    public bool AccountAlreadyExists(AccountEntity account)
    {
        return false;
    }

    public int CreateNewAccount(AccountEntity account)
    {
        var rowAffects = 1;

        return rowAffects;
    }

    public decimal GetAccountBalance(AccountEntity account)
    {
        decimal balance = 1350;
        return balance;
    }
}