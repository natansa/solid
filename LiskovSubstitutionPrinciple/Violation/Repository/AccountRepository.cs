using SOLID.LiskovSubstitutionPrinciple.Violation.Entities;

namespace SOLID.LiskovSubstitutionPrinciple.Violation.Repository;

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