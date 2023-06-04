using Api.InterfaceSegregationPrinciple.Violation.Models;
using Api.InterfaceSegregationPrinciple.Violation.Entities;
using Api.InterfaceSegregationPrinciple.Violation.Repository;
using System.Security.Principal;

namespace Api.InterfaceSegregationPrinciple.Violation.Services;

public class AccountService
{
    private readonly AccountRepository _accountRepository;

    public AccountService(AccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public CreateAccountResult Create(AccountEntity account)
    {
        ValidateAccount(account);
        var rowAffecteds = _accountRepository.CreateNewAccount(account);
        var success = rowAffecteds > 0;
        return new CreateAccountResult(success, account);
    }

    public AccountEntity GetAccountBalance(AccountEntity accountEntity)
    {
        decimal accountBalance = _accountRepository.GetAccountBalance(accountEntity);
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
        var accountAlreadyExists = _accountRepository.AccountAlreadyExists(account);
        return accountAlreadyExists;
    }
}