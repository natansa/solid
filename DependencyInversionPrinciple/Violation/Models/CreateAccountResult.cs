using Api.DependencyInversionPrinciple.Violation.Entities;

namespace Api.DependencyInversionPrinciple.Violation.Models
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