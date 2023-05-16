namespace SOLID.SingleResponsibilityPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountInput
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string Cpf { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
}