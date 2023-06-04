namespace Api.OpenClosedPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountOcpSolutionInput
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string Cpf { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public int AccountType { get; set; }
}