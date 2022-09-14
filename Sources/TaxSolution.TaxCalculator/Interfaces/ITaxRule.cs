using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.TaxCalculator.Entity;

namespace TaxSolution.TaxCalculator.Interfaces;

public interface ITaxRule
{
    int CalculateTaxPercentage(TaxPayer taxPayer, int currentPercentage);
}
