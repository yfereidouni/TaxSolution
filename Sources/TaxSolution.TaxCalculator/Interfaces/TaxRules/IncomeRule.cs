using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.TaxCalculator.Entity;

namespace TaxSolution.TaxCalculator.Interfaces.TaxRulesl;

public class IncomeRule : ITaxRule
{
    public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer, double currentPercentage)
    {
        if (taxPayer.GrossIncome < 40000) taxPayer.TaxedAmount = 0;
        else
        {
            taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * 0.1);
        }
        return taxPayer;
    }
}