using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.TaxCalculator.Entity;
using TaxSolution.TaxCalculator.Infrastructures;
using TaxSolution.TaxCalculator.Interfaces;

namespace TaxSolution.TaxCalculator.Services
{
    public class TaxCalculatorService
    {
        public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
        {
            var ruleType = typeof(ITaxRule);

            // As soon as defining any rules it add to our Engine ------------
            IEnumerable<ITaxRule> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as ITaxRule);
            //-----------------------------------------------------------------

            var engine = new TaxRuleEngine(rules);

            return engine.CalculateTaxPercentage(taxPayer);
        }
    }
}
