using SOLID.SingleResponsibilityPrinciple.Solution.Boundaries.CreateAccount;
using SOLID.SingleResponsibilityPrinciple.Solution.Entities;
using SOLID.SingleResponsibilityPrinciple.Solution.Repository;
using SOLID.SingleResponsibilityPrinciple.Solution.Services;
using SOLID.SingleResponsibilityPrinciple.Solution.ValueObjects;

namespace SOLID.SingleResponsibilityPrinciple.Solution.UseCases;

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

    public CreateAccountOutput Create(CreateAccountInput input)
    {
        bool successCreatedPhysicalPerson = CreatedPhysicalPerson(input);

        var successCreatedAccount = _accountService.Create(new AccountEntity(password: input.Password));

        if (successCreatedPhysicalPerson && successCreatedAccount.Success)
        {
            _smsService.Send(input.Phone);
            return new CreateAccountOutput(successCreatedAccount.AccountEntity.AccountNumber);
        }

        return default;
    }

    private bool CreatedPhysicalPerson(CreateAccountInput input)
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