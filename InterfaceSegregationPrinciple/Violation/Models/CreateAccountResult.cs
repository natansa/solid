using SOLID.InterfaceSegregationPrinciple.Violation.Entities;

namespace Api.InterfaceSegregationPrinciple.Violation.Models
{
    public class CreateAccountResult
    {
        public CreateAccountResult(bool success, AccountEntity accountEntity)
        {
            Success = success;
            AccountEntity = accountEntity;
        }

        public bool Success { get; }
        public AccountEntity AccountEntity { get; }
    }
}