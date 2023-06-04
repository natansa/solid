﻿namespace Api.InterfaceSegregationPrinciple.Violation.Boundaries.CreateAccount;

public class CreateAccountIspViolationInput
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string Document { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public int AccountType { get; set; }
    public int Token { get; set; }
}