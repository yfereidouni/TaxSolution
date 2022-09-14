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
    public void Tax_For_Retired()
    {
        //Arrange
        TaxPayer taxPayer = new TaxPayer
        {
            GrossIncome = 45700,
            IsSingle = true,
            IsRetired = true,
            TaxedAmount = 0
        };

        //Act
        var result = _calculator.CalculateTaxPercentage(taxPayer);

        //Assert
        Assert.Equal(1710, result.TaxedAmount);
    }


}

