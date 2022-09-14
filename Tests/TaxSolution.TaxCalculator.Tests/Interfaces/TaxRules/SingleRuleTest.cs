using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.TaxCalculator.Entity;
using TaxSolution.TaxCalculator.Services;

namespace TaxSolution.TaxCalculator.Tests.Interfaces.TaxRules
{

    public class SingleRuleTest
    {
        private TaxCalculatorService _calculator = new TaxCalculatorService();

        [Fact]
        public void Tax_For_SingleTaxPayer()
        {
            //Arrange
            TaxPayer taxPayer = new TaxPayer
            {
                GrossIncome = 45000,
                IsSingle = true,
                HasHealthInsurance = true,
                HealthInsuranceAnnualPremium = 3000,
                IsResidentOrCitizen = true,
                TaxedAmount = 0
            };

            //Act
            var result = _calculator.CalculateTaxPercentage(taxPayer);

            //Assert
            Assert.Equal(1500, result.TaxedAmount);
        }
    }
}
