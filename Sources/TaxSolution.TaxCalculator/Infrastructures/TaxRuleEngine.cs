using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.TaxCalculator.Entity;
using TaxSolution.TaxCalculator.Interfaces;

namespace TaxSolution.TaxCalculator.Infrastructures
{
    public class TaxRuleEngine
    {
        List<ITaxRule> _rules = new List<ITaxRule>();

        public TaxRuleEngine(IEnumerable<ITaxRule> rules)
        {
            _rules.AddRange(rules);
        }

        public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
        {
            foreach (var rule in _rules)
            {
                taxPayer.TaxedAmount += rule.CalculateTaxPercentage(taxPayer, taxPayer.TaxedAmount).TaxedAmount;
            }
            return taxPayer;
        }
    }
}
