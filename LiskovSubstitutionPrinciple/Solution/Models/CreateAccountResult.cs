using SOLID.LiskovSubstitutionPrinciple.Solution.Entities;

namespace Api.LiskovSubstitutionPrinciple.Solution.Models
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