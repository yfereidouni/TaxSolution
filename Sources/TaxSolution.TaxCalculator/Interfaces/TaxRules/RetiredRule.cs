using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.TaxCalculator.Entity;

namespace TaxSolution.TaxCalculator.Interfaces.TaxRules;

public class RetiredRule : ITaxRule
{
    public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer, double currentPercentage)
    {
        if (taxPayer.IsRetired)
            taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * 0);

        return taxPayer;
    }
}
