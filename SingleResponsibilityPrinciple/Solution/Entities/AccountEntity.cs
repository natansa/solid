using System.Text;

namespace Api.SingleResponsibilityPrinciple.Solution.Entities;

public class AccountEntity
{
    public AccountEntity(string password)
    {
        CreateAccount();
        Password = password;
    }

    public string AccountNumber { get; private set; }
    public string Password { get; private set; }

    public bool IsInvalid() 
    {
        if (PasswordHasMinimumRequirements()) return true;

        return false;
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