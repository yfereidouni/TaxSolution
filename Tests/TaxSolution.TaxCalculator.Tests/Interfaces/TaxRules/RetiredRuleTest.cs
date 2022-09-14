using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSolution.TaxCalculator.Entity;
using TaxSolution.TaxCalculator.Services;

namespace TaxSolution.TaxCalculator.Tests.Interfaces.TaxRules;

public class RetiredRuleTest
{
    private TaxCalculatorService _calculator = new TaxCalculatorService();

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
}

