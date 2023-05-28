using SOLID.InterfaceSegregationPrinciple.Violation.Entities;

namespace SOLID.InterfaceSegregationPrinciple.Violation.Repository;

public class AccountRepository
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
}