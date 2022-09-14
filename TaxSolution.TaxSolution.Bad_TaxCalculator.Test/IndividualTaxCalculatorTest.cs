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
        private TaXCalculator _calculator = new TaXCalculator();

        [Fact]
        public void Retired_TaxPayer_SHOULD_Pay_One_Percent_Tax()
        {
            //Arrange
            TaxPayer taxPayer = new TaxPayer
            {
                TaxCitizen = true,
                HasDisability = false,
                IsRetired = true
            };

            //Act
            var result = _calculator.CalculateTaxPercentage(taxPayer);

            //Assert
            Assert.Equal(1, result);
        }

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

        [Fact]
        public void Disable_TaxPayer_Should_Be_Zero_Percent_Tax()
        {
            //Arrange
            TaxPayer taxPayer = new TaxPayer()
            {
                TaxCitizen = true,
                HasDisability = true
            };
            IndividualTaxCalculator individualTaxCalculator = new IndividualTaxCalculator();

            //Act
            var result = individualTaxCalculator.CalculateTaxPercentage(taxPayer);

            //Assert
            Assert.Equal(0, result);
        }
    }
}
