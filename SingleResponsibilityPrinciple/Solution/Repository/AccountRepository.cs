using Api.SingleResponsibilityPrinciple.Solution.Entities;

namespace Api.SingleResponsibilityPrinciple.Solution.Repository;

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