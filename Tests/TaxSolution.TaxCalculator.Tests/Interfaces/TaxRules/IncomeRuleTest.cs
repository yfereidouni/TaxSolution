using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.TaxCalculator.Entity;
using TaxSolution.TaxCalculator.Services;

namespace TaxSolution.TaxCalculator.Tests.Interfaces.TaxRules
{

    public class IncomeRuleTest
    {
        private TaxCalculatorService _calculator = new TaxCalculatorService();

        [Fact]
        public void Tax_For_Income()
        {
            //Arrange
            TaxPayer taxPayer = new TaxPayer
            {
                GrossIncome = 40000,
                IsSingle = true,
                HasHealthInsurance = true,
                HealthInsuranceAnnualPremium = 3000,
                IsResidentOrCitizen = true,
                TaxedAmount = 0
            };

            //Act
            var result = _calculator.CalculateTaxPercentage(taxPayer);

            //Assert
            Assert.Equal(0, result.TaxedAmount);
        }
    }
}
