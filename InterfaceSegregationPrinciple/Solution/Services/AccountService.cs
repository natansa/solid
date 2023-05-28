using SOLID.InterfaceSegregationPrinciple.Solution.Entities;
using SOLID.InterfaceSegregationPrinciple.Solution.Repository;
using SOLID.InterfaceSegregationPrinciple.Solution.Services.Interfaces;

namespace SOLID.InterfaceSegregationPrinciple.Solution.Services;

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