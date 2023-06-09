﻿using Api.OpenClosedPrinciple.Violation.Boundaries.CreateAccount;
using Api.OpenClosedPrinciple.Violation.Entities;
using Api.OpenClosedPrinciple.Violation.Enums;
using Api.OpenClosedPrinciple.Violation.Repository;
using Api.OpenClosedPrinciple.Violation.Services;
using Api.OpenClosedPrinciple.Violation.ValueObjects;

namespace Api.OpenClosedPrinciple.Violation.UseCases;

public class CreateAccountUseCase
{
    private readonly PhysicalPersonService _physicalPersonService;
    private readonly AccountService _accountService;
    private readonly SmsService _smsService;
    private readonly ComplianceService _complianceService;
    private readonly B3Service _b3Service;

    public CreateAccountUseCase()
    {
        _physicalPersonService = new PhysicalPersonService(new PhysicalPersonRepository());
        _accountService = new AccountService(new AccountRepository());
        _smsService = new SmsService();
        _complianceService = new ComplianceService();
        _b3Service = new B3Service();
    }

    public CreateAccountOcpViolationOutput Create(CreateAccountOcpViolationInput input)
    {
        bool successCreatedPhysicalPerson = CreatedPhysicalPerson(input);

        var successCreatedAccount = _accountService.Create(new AccountEntity
        (
            password: input.Password,
            accountType: (AccountType)Enum.ToObject(typeof(AccountType), input.AccountType)
        ));

        if (successCreatedPhysicalPerson && successCreatedAccount.Success)
        {
            if (successCreatedAccount.AccountEntity.AccountType.Equals(AccountType.IndividualAccount))
            {
                _smsService.Send(input.Phone);
            }

            if (successCreatedAccount.AccountEntity.AccountType.Equals(AccountType.CorporateAccount))
            {
                _complianceService.Send(successCreatedAccount.AccountEntity.AccountNumber);
            }

            if (successCreatedAccount.AccountEntity.AccountType.Equals(AccountType.InvestmentAccount))
            {
                _b3Service.Send(successCreatedAccount.AccountEntity.AccountNumber);
            }

            return new CreateAccountOcpViolationOutput(successCreatedAccount.AccountEntity.AccountNumber);
        }

        return default;
    }

    private bool CreatedPhysicalPerson(CreateAccountOcpViolationInput input)
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