using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.Bad_TaxCalculator.Entity;

namespace TaxSolution.Bad_TaxCalculator;

public class IndividualTaxCalculator
{
    public int CalculateTaxPercentage(TaxPayer taxPayer)
    {
        if (!taxPayer.TaxCitizen)
        {
            throw new InvalidOperationException("No TAX calculation for NON-TAX Residents");
        }

        return 0;
    }
}
