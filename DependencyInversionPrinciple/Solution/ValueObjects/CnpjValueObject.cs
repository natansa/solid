namespace Api.DependencyInversionPrinciple.Solution.ValueObjects
{
    public class CnpjValueObject
    {
        public CnpjValueObject(string cnpj)
        {
            Cnpj = cnpj;
        }

        public string Cnpj { get; private set; }

        public bool IsInvalid()
        {
            return true;
        }

        public string GetFormatted() 
        {
            return string.Format(Cnpj, "00.000.000/0000-00");
        }

        public string GetWithoutFormatting()
        {
            return Cnpj.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty).Replace(" ", string.Empty);
        }
    }
}