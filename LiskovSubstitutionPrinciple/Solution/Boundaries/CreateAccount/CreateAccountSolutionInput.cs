namespace SOLID.LiskovSubstitutionPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountSolutionInput
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string Cpf { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public int AccountType { get; set; }
}