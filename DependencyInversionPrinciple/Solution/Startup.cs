using Microsoft.Extensions.DependencyInjection;
using SOLID.DependencyInversionPrinciple.Solution.Repository;
using SOLID.DependencyInversionPrinciple.Solution.Repository.Interfaces;
using SOLID.DependencyInversionPrinciple.Solution.Services;
using SOLID.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;
using SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces;
using SOLID.DependencyInversionPrinciple.Solution.Services.Interfaces.AccountTypeAnalisys;
using SOLID.DependencyInversionPrinciple.Solution.UseCases;
using SOLID.DependencyInversionPrinciple.Solution.UseCases.Interfaces;

namespace SOLID.DependencyInversionPrinciple.Solution;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        ConfigureRepository(services);
        ConfigureService(services);
        ConfigureHandlers(services);
        ConfigureUseCase(services);
    }

    private void ConfigureRepository(IServiceCollection services) 
    {
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<ILegalPersonRepository, LegalPersonRepository>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IPhysicalPersonRepository, PhysicalPersonRepository>();
    }

    private void ConfigureService(IServiceCollection services)
    {
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IAccountTypeAnalisysService, AccountTypeAnalisysService>();
        services.AddScoped<IPersonCommandService, PersonService>();
        services.AddScoped<IPersonQueryService, PersonService>();
        services.AddScoped<IPersonService, PersonService>();
        services.AddScoped<IB3Service, B3Service>();
        services.AddScoped<IComplianceService, ComplianceService>();
        services.AddScoped<ISmsService, SmsService>();
    }

    private void ConfigureHandlers(IServiceCollection services) 
    {
        services.AddScoped<ICorporateAccountHandler, CorporateAccountHandler>();
        services.AddScoped<IIndividualAccountHandler, IndividualAccountHandler>();
        services.AddScoped<IInvestmentAccountHandler, InvestmentAccountHandler>();
    }

    private void ConfigureUseCase(IServiceCollection services)
    {
        services.AddScoped<ICreateAccountUseCase, CreateAccountUseCase>();
    }
}
