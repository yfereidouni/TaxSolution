using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.TaxCalculator.Entity;

namespace TaxSolution.TaxCalculator.Interfaces.TaxRules;

public class RetiredRule : ITaxRule
{
    public int CalculateTaxPercentage(TaxPayer taxPayer, int currentPercentage)
    {
        if (taxPayer.IsRetired)
        {
            return 1;
        }
        return 0;
    }
}
