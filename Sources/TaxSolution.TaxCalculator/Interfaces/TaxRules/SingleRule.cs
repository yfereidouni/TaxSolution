using TaxSolution.TaxCalculator.Entity;

namespace TaxSolution.TaxCalculator.Interfaces.TaxRulesl;

public class SingleRule : ITaxRule
{
    public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer, double currentPercentage)
    {
        if (taxPayer.IsSingle)
            //taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * 0.1);
            taxPayer.TaxedAmount = 10;

        return taxPayer;
    }
}
