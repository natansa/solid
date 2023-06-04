using Api.LiskovSubstitutionPrinciple.Solution.Services;
using Api.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys;

namespace Api.LiskovSubstitutionPrinciple.Solution.Services.AccountTypeAnalisys.Strategy;

public class InvestmentAccountStrategyHandler : AccountTypeAnalisyStrategyHandler
{
    private readonly B3Service _b3Service;

    public InvestmentAccountStrategyHandler()
    {
        _b3Service = new B3Service();
    }

    public InvestmentAccountStrategyHandler(AccountTypeAnalisy accountTypeAnalisy)
    {
        _b3Service = new B3Service();
        AccountTypeAnalisy = accountTypeAnalisy;
    }

    public override void HandleRequest(AccountTypeAnalisy accountTypeAnalisy)
    {
        if (accountTypeAnalisy.AccountEntity.IsInvestmentAccount())
        {
            _b3Service.Send(accountTypeAnalisy.AccountEntity.AccountNumber);
            return;
        }
    }

    public override void HandleRequest()
    {
        if (AccountTypeAnalisy.AccountEntity.IsInvestmentAccount())
        {
            _b3Service.Send(AccountTypeAnalisy.AccountEntity.AccountNumber);
            return;
        }
    }
}