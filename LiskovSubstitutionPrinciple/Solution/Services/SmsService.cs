namespace SOLID.LiskovSubstitutionPrinciple.Solution.Services;

public class SmsService
{
    private readonly string _accessKeyZenvia;
    private readonly string _secretKeyZenvia;

    public SmsService()
    {
        _accessKeyZenvia = "AccessKeyZenvia";
        _secretKeyZenvia = "SecretKeyZenvia";
    }

    public void Send(string phone) 
    {
        // INSTANCIA SERVICO DA ZENVIA
        // INSERE A ACCESS KEY
        // INSERE A SECRET KEY
        // FAZ O ENVIO DO SMS -> PARABENS SUA CONTA FOI ABERTA
    }
}