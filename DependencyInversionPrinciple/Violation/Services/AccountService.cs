using Api.DependencyInversionPrinciple.Violation.Models;
using Api.DependencyInversionPrinciple.Violation.Services.Interfaces;
using Api.DependencyInversionPrinciple.Violation.Entities;
using Api.DependencyInversionPrinciple.Violation.Repository.Interfaces;

namespace Api.DependencyInversionPrinciple.Violation.Services;

public class AccountService : IAccountService
{
    private readonly IAccountCommandRepository _accountCommandRepository;
    private readonly IAccountQueryRepository _accountQueryRepository;

    public AccountService(IAccountCommandRepository accountCommandRepository, 
                          IAccountQueryRepository accountQueryRepository)
    {
        _accountCommandRepository = accountCommandRepository;
        _accountQueryRepository = accountQueryRepository;
    }

    public CreateAccountResult Create(AccountEntity account)
    {
        ValidateAccount(account);
        var rowAffecteds = _accountCommandRepository.CreateNewAccount(account);
        var success = rowAffecteds > 0;
        return new CreateAccountResult(success, account);
    }

    public AccountEntity GetAccountBalance(AccountEntity accountEntity)
    {
        decimal accountBalance = _accountQueryRepository.GetAccountBalance(accountEntity);
        accountEntity.AddAccountBalance(accountBalance);
        return accountEntity;
    }

    private void ValidateAccount(AccountEntity account) 
    {
        if (account == null) throw new ArgumentNullException(nameof(AccountEntity));

        if (account.IsInvalid()) throw new InvalidOperationException(nameof(AccountEntity));

        if (AccountAlreadyExists(account)) throw new InvalidOperationException($"Conta {account.AccountNumber} ja existe");
    }

    private bool AccountAlreadyExists(AccountEntity account) 
    {
        var accountAlreadyExists = _accountQueryRepository.AccountAlreadyExists(account);
        return accountAlreadyExists;
    }
}