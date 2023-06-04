using Api.DependencyInversionPrinciple.Solution.Repository;
using Api.DependencyInversionPrinciple.Solution.Repository.Interfaces;
using Api.DependencyInversionPrinciple.Solution.Services;
using Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys;
using Api.DependencyInversionPrinciple.Solution.Services.AccountTypeAnalisys.Interfaces;
using Api.DependencyInversionPrinciple.Solution.Services.Interfaces;
using Api.DependencyInversionPrinciple.Solution.UseCases;
using Api.DependencyInversionPrinciple.Solution.UseCases.Interfaces;

namespace Api.DependencyInversionPrinciple.Solution;

public static class Startup
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        ConfigureRepository(services);
        ConfigureService(services);
        ConfigureUseCase(services);
    }

    private static void ConfigureRepository(IServiceCollection services)
    {
        services.AddScoped<IAccountCommandRepository, AccountRepository>();
        services.AddScoped<IAccountQueryRepository, AccountRepository>();
        services.AddScoped<ILegalPersonCommandRepository, LegalPersonRepository>();
        services.AddScoped<ILegalPersonQueryRepository, LegalPersonRepository>();
        services.AddScoped<IPhysicalPersonCommandRepository, PhysicalPersonRepository>();
        services.AddScoped<IPhysicalPersonQueryRepository, PhysicalPersonRepository>();
    }

    private static void ConfigureService(IServiceCollection services)
    {
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IB3Service, B3Service>();
        services.AddScoped<IComplianceService, ComplianceService>();
        services.AddScoped<ILegalPersonService, LegalPersonService>();
        services.AddScoped<IPersonService, PersonService>();
        services.AddScoped<IPhysicalPersonService, PhysicalPersonService>();
        services.AddScoped<ISmsService, SmsService>();
        services.AddScoped<IAccountTypeAnalisysService,  AccountTypeAnalisysService>();
    }

    private static void ConfigureUseCase(IServiceCollection services)
    {
        services.AddScoped<ICreateAccountUseCase, CreateAccountUseCase>();
        services.AddScoped<IGetAccountBalanceUseCase, GetAccountBalanceUseCase>();
    }
}
