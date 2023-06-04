using Api.DependencyInversionPrinciple.Solution.Boundaries.CreateAccount;

namespace Api.DependencyInversionPrinciple.Solution.UseCases.Interfaces
{
    public interface ICreateAccountUseCase
    {
        CreateAccountOutput Create(CreateAccountInput input);
    }
}