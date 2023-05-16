using SOLID.SingleResponsibilityPrinciple.Violation.Entities;

namespace SOLID.SingleResponsibilityPrinciple.Violation.Repository;

public class AccountRepository
{
    public bool AccountAlreadyExists(string account)
    {
        return false;
    }

    public void CreateNewAccount(string account)
    {
        
    }
}