namespace Api.DependencyInversionPrinciple.Violation.Services.Interfaces;

public interface ISmsService
{
    void Send(string phone);
}
