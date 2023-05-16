using SOLID.OpenClosedPrinciple.Violation.Entities;

namespace SOLID.OpenClosedPrinciple.Violation.Repository;

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