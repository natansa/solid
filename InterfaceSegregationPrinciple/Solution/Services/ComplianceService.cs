namespace SOLID.InterfaceSegregationPrinciple.Solution.Services;

public class ComplianceService
{
    private readonly string _topicKafkaCompliance;

    public ComplianceService()
    {
        _topicKafkaCompliance = "TopicKafkaCompliance";
    }

    public void Send(string accountNumber)
    {
        // INSTANCIA SERVICO DO KAFKA
        // PUBLICA O NUMERO DA CONTA PARA SER ANALISADO PELA AREA DE COMPLIANCE
    }
}