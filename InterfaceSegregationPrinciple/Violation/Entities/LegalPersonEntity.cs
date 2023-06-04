using Api.InterfaceSegregationPrinciple.Violation.ValueObjects;

namespace Api.InterfaceSegregationPrinciple.Violation.Entities;

public class LegalPersonEntity : PersonEntity
{
    public LegalPersonEntity(string name, CnpjValueObject cnpj, string phone, int token) 
        : base(name, phone, token)
    {
        Cnpj = cnpj;
    }

    public CnpjValueObject Cnpj { get; private set; }

    public override bool IsInvalid()
    {
        if (Cnpj.IsInvalid()) return true;

        return false;
    }

    public override bool TokenIsValid()
    {
        throw new InvalidOperationException("Pessoa Jurídica não tem token");
    }
}