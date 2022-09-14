using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.Bad_TaxCalculator.Entity;

namespace TaxSolution.Bad_TaxCalculator.Test
{
    public class IndividualTaxCalculatorTest
    {
        [Fact]
        public void None_TaxResident_SHOULD_NOT_BE_Calculate()
        {
            //Arrange
            TaxPayer taxPayer = new TaxPayer
            {
                TaxCitizen = false
            };
            IndividualTaxCalculator individualTaxCalculator = new IndividualTaxCalculator();

            //Act
            string exceptedErrorMessage = "No TAX calculation for NON-TAX Residents";
            
            var ExceptionResult = Assert.Throws<InvalidOperationException>(() =>
            individualTaxCalculator.CalculateTaxPercentage(taxPayer));

            //Assert
            Assert.Equal(exceptedErrorMessage, ExceptionResult.Message);
        }
    }
}
