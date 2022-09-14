using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxSolution.TaxCalculator.Entity;

public class TaxPayer
{
    //public bool TaxCitizen { get; set; }
    //public bool HasDisability { get; set; }
    //public bool IsMuslim { get; set; }
    //public decimal ZakatPaid { get; set; }
    //public bool IsRetired { get; set; }
    //public bool MaritalStatus { get; set; }

    public double GrossIncome { get; set; }
    public bool IsSingle { get; set; }
    public bool IsRetired { get; set; }
    public bool IsResidentOrCitizen { get; set; }
    public bool HasHealthInsurance { get; set; }
    public bool HasBusiness { get; set; }
    public bool AtlossInBusiness { get; set; }
    public double TaxedAmount { get; set; }
    public double HealthInsuranceAnnualPremium { get; set; } 
}
