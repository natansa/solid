using SOLID.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;

namespace SOLID.DependencyInversionPrinciple.Solution.UseCases.Interfaces
{
    public interface ICreateAccountUseCase
    {
        CreateAccountOutput Create(CreateAccountInput input);
    }
}