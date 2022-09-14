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

        public int CalculateTaxPercentage(TaxPayer taxPayer)
        {
            int TaxPercentage = 0;
            foreach (var rule in _rules)
            {
                TaxPercentage = Math.Max(TaxPercentage, rule.CalculateTaxPercentage(taxPayer, TaxPercentage));
            }

            return TaxPercentage;
        }
    }
}
