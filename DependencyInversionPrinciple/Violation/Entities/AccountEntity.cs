using Api.DependencyInversionPrinciple.Violation.Enums;
using System.Text;

namespace Api.DependencyInversionPrinciple.Violation.Entities;

public class AccountEntity
{
    public AccountEntity(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public AccountEntity(string password, AccountType accountType)
    {
        CreateAccount();
        Password = password;
        AccountType = accountType;
    }

    public string AccountNumber { get; private set; }
    public string Password { get; private set; }
    public AccountType AccountType { get; private set; }
    public decimal AccountBalance { get; private set; }

    public bool IsInvalid() 
    {
        if (PasswordHasMinimumRequirements()) return true;

        return false;
    }

    public bool IsIndividualAccount()
    {
        return AccountType.Equals(AccountType.IndividualAccount);
    }

    public bool IsCorporateAccount()
    {
        return AccountType.Equals(AccountType.CorporateAccount);
    }

    public bool IsInvestmentAccount()
    {
        return AccountType.Equals(AccountType.InvestmentAccount);
    }

    public void AddAccountBalance(decimal accountBalance)
    {
        AccountBalance = accountBalance;
    }

    private void CreateAccount()
    {
        var accountNumber = new StringBuilder();

        for (int i = 0; i < 7; i++)
        {
            var random = new Random();
            var accountNumberChar = Convert.ToChar(random.Next(48, 58));
            accountNumber.Append(accountNumberChar);
        }

        AccountNumber = accountNumber.ToString();
    }

    private bool PasswordHasMinimumRequirements() 
    {
        if (Password.Length < 10) return false;

        return true;
    }
}