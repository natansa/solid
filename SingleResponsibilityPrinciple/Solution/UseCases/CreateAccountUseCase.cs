using Api.SingleResponsibilityPrinciple.Solution.Boundaries.CreateAccount;
using Api.SingleResponsibilityPrinciple.Solution.Entities;
using Api.SingleResponsibilityPrinciple.Solution.Repository;
using Api.SingleResponsibilityPrinciple.Solution.Services;
using Api.SingleResponsibilityPrinciple.Solution.ValueObjects;

namespace Api.SingleResponsibilityPrinciple.Solution.UseCases;

public class CreateAccountUseCase
{
    private readonly PhysicalPersonService _physicalPersonService;
    private readonly AccountService _accountService;
    private readonly SmsService _smsService;

    public CreateAccountUseCase()
    {
        _physicalPersonService = new PhysicalPersonService(new PhysicalPersonRepository());
        _accountService = new AccountService(new AccountRepository());
        _smsService = new SmsService();
    }

    public CreateAccountSrpSolutionOutput Create(CreateAccountSrpSolutionInput input)
    {
        bool successCreatedPhysicalPerson = CreatedPhysicalPerson(input);

        var successCreatedAccount = _accountService.Create(new AccountEntity(password: input.Password));

        if (successCreatedPhysicalPerson && successCreatedAccount.Success)
        {
            _smsService.Send(input.Phone);
            return new CreateAccountSrpSolutionOutput(successCreatedAccount.AccountEntity.AccountNumber);
        }

        return default;
    }

    private bool CreatedPhysicalPerson(CreateAccountSrpSolutionInput input)
    {
        return _physicalPersonService.Create(new PhysicalPersonEntity
        (
            name: input.Name,
            birthday: input.Birthday,
            cpf: new CpfValueObject(input.Cpf),
            phone: input.Phone
        ));
    }
}