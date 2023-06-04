using Api.InterfaceSegregationPrinciple.Solution.Models;
using Api.InterfaceSegregationPrinciple.Solution.Services.Interfaces;
using Api.InterfaceSegregationPrinciple.Solution.Entities;
using Api.InterfaceSegregationPrinciple.Solution.Repository;

namespace Api.InterfaceSegregationPrinciple.Solution.Services;

public class AccountService : IAccountService
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