namespace Api.SingleResponsibilityPrinciple.Solution.Boundaries.CreateAccount;

public class CreateAccountSrpSolutionInput
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string Cpf { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
}