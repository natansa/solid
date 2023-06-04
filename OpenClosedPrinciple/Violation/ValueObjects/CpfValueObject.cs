namespace Api.OpenClosedPrinciple.Violation.ValueObjects
{
    public class CpfValueObject
    {
        public CpfValueObject(string cpf)
        {
            Cpf = cpf;
        }

        public string Cpf { get; private set; }

        public bool IsInvalid()
        {
            return false;
        }

        public string GetFormatted() 
        {
            return string.Format(Cpf, "000.000.000-00");
        }

        public string GetWithoutFormatting()
        {
            return Cpf.Replace(".", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty);
        }
    }
}