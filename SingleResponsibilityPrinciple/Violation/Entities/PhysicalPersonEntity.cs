using System.Text;

namespace Api.SingleResponsibilityPrinciple.Violation.Entities;

public class PhysicalPersonEntity
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string Cpf { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }

    private string AccountNumber { get; set; }

    public void CreateAccount()
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

    public bool CpfIsValid()
    {
        return true;
    }

    public void SetPassord(string password)
    {
        Password = password;
    }

    public bool IsOfLegalAge()
    {
        return DateTime.Now.Year - Birthday.Year > 18;
    }

    public string GetAccountNumber()
    {
        return AccountNumber;
    }
}