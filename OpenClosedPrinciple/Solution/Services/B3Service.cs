using Microsoft.Extensions.Configuration;

namespace SOLID.OpenClosedPrinciple.Solution.Services;

public class B3Service
{
    private readonly string _endpointHttpB3;

    public B3Service()
    {
        _endpointHttpB3 = "EndpointHttpB3";
    }

    public void Send(string accountNumber)
    {
        // INSTANCIA SERVICO HTTPCLIENT
        // ENVIA O NUMERO DA CONTA PARA B3
    }
}