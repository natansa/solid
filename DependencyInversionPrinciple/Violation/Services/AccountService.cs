using SOLID.DependencyInversionPrinciple.Violation.Entities;
using SOLID.DependencyInversionPrinciple.Violation.Repository;
using SOLID.DependencyInversionPrinciple.Violation.Services.Interfaces;

namespace SOLID.DependencyInversionPrinciple.Violation.Services;

public class AccountService : IAccountService
{
    private readonly AccountRepository _accountRepository;

    public AccountService(AccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public (bool Success, AccountEntity AccountEntity) Create(AccountEntity account)
    {
        ValidateAccount(account);
        var rowAffecteds = _accountRepository.CreateNewAccount(account);
        var success = rowAffecteds > 0;
        return new (success, account);
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