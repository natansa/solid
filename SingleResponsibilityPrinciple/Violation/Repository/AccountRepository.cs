using Api.SingleResponsibilityPrinciple.Violation.Entities;

namespace Api.SingleResponsibilityPrinciple.Violation.Repository;

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