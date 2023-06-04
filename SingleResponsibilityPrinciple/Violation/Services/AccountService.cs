using Api.SingleResponsibilityPrinciple.Violation.Entities;
using Api.SingleResponsibilityPrinciple.Violation.Repository;

namespace Api.SingleResponsibilityPrinciple.Violation.Services;

public class AccountService
{
    private readonly AccountRepository _accountRepository;
    private readonly PhysicalPersonRepository _physicalPersonRepository;
    private readonly string _accessKeyZenvia;
    private readonly string _secretKeyZenvia;

    public AccountService()
    {
        _accountRepository = new AccountRepository();
        _physicalPersonRepository = new PhysicalPersonRepository();
        _accessKeyZenvia = "AccessKeyZenvia";
        _secretKeyZenvia = "SecretKeyZenvia";
    }

    public void CreateAccount(PhysicalPersonEntity physicalPerson)
    {
        if (physicalPerson == null) throw new ArgumentNullException(nameof(physicalPerson));

        if (!physicalPerson.CpfIsValid()) throw new InvalidOperationException("CPF Invalido");

        if (!physicalPerson.IsOfLegalAge()) throw new InvalidOperationException("Menor de idade nao pode abrir conta");

        var physicalPersonAlreadyExists = _physicalPersonRepository.PhysicalPersonAlreadyExists(physicalPerson.Cpf);

        if (physicalPersonAlreadyExists) throw new InvalidOperationException($"Pessoa {physicalPerson.Cpf} ja existe");

        _physicalPersonRepository.CreateNewPhysicalPerson(physicalPerson.Name, physicalPerson.Cpf);

        physicalPerson.CreateAccount();

        var accountAlreadyExists = _accountRepository.AccountAlreadyExists(physicalPerson.GetAccountNumber());

        if (accountAlreadyExists) throw new InvalidOperationException($"Conta {physicalPerson.GetAccountNumber()} ja existe");

        _accountRepository.CreateNewAccount(physicalPerson.GetAccountNumber());

        SendSms(physicalPerson);
    }

    private void SendSms(PhysicalPersonEntity physicalPerson)
    {
        // INSTANCIA SERVICO DA ZENVIA
        // INSERE A ACCESS KEY
        // INSERE A SECRET KEY
        // FAZ O ENVIO DO SMS -> PARABENS SUA CONTA FOI ABERTA
    }
}